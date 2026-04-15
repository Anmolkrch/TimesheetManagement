using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManagement.Interface;
using TimeSheetManagement.Models;

namespace TimeSheetManagement.Concrete
{
    public class AuditConcrete : IAudit
    {
        public void InsertAuditData(AuditTB audittb)
        {
            using (var _context = new DatabaseContext())
            {
                _context.AuditTB.Add(audittb);
                _context.SaveChanges();
            }
        }
    }
}
