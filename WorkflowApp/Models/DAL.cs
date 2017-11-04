using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WorkflowApp.Models
{
    public class DAL
    {
        /// <summary>
        /// 快速查询集合，未处理
        /// </summary>
        /// <param name="UserLoginName"></param>
        /// <returns></returns>
        public DataTable QueryProcessAssemble(string UserLoginName)
        {
            string Selsql = @"select  count(ModelId) Total,ModelId  from wx_org_process
                              where `Status`=0 and ProcessData not like '%申请人出差返回%'
                              and Approvers=@Approvers
                              and ModelId not in ('97028','440370' , '233206' , '440871' , '440839' , '261242' , '237386' ,'216219')
                              group by modelId order by ModelId;
                             ";
            return DB.Context.FromSql(Selsql).AddInParameter("Approvers",DbType.String,UserLoginName).ToDataTable();
        }
        /// <summary>
        /// 快速查询集合,已处理
        /// </summary>
        /// <param name="UserLoginName"></param>
        /// <returns></returns>
        public DataTable QueryProcessAssemble_Processed(string UserLoginName)
        {
            string Selsql = @"select  count(ModelId) Total,ModelId  from wx_org_process_Processed
                              where `Status`=1 and ProcessData not like '%申请人出差返回%'
                              and Approvers=@Approvers
                              and ModelId not in ('97028','440370' , '233206' , '440871' , '440839' , '261242' , '237386' , '216219')
                              group by modelId order by ModelId;
                             ";
            return DB.Context.FromSql(Selsql).AddInParameter("Approvers", DbType.String, UserLoginName).ToDataTable();
        }
    }
}