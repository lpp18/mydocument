using ApplicationModel.Models;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;

namespace RCSApplication.Models
{
    public class QRCode
    {
        public string filePath = HttpContext.Current.Server.MapPath("~/UploadFiles/QRCode/");
        public string RelativePath = "../../UploadFiles/QRCode/";

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="Content">内容文本</param>
        /// <param name="size">图片尺寸（像素），0表示不设置</param>
        /// <returns></returns>
        public string CreateQRCode(string Content, int Size)
        {
            Graphics g = null;
            Bitmap img = null;
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(Content);
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(Size, QuietZoneModules.Four), Brushes.Black, Brushes.White);
            Point padding = new Point(10, 10);
            DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            img = new Bitmap(dSize.CodeWidth + padding.X, dSize.CodeWidth + padding.Y);
            //创建GDI绘图图面对象
            g = Graphics.FromImage(img);
            render.Draw(g, qrCode.Matrix, padding);
            //创建文件夹
            Common.CreateDir(filePath);
            //文件名称   
            string guid = Guid.NewGuid().ToString().Replace("-", "") + ".png";
            RelativePath += guid;
            string QRCodePath = filePath + "/" + guid;
            try
            {
                using (FileStream stream = new FileStream(QRCodePath, FileMode.Create))
                {
                    render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
                }
            }
            catch (Exception e)
            {
                string ServiceName = "SaveQRCode";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            finally
            {
                //释放占用资源
                img.Dispose();
                g.Dispose();
            }
            return RelativePath;

        }

    }
}