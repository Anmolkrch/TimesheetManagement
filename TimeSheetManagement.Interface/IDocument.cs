using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManagement.Models;

namespace TimeSheetManagement.Interface
{
    public interface IDocument
    {
        int AddDocument(Documents Documents);
        Documents GetDocumentByExpenseID(int? ExpenseID, int? DocumentID);
        List<DocumentsVM> GetListofDocumentByExpenseID(int? ExpenseID);
    }
}
