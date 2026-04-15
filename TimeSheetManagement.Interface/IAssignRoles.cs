using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManagement.Models;

namespace TimeSheetManagement.Interface
{
    public interface IAssignRoles
    {
        List<AdminModel> ListofAdmins();
        List<UserModel> ListofUser();
        int UpdateAssigntoAdmin(string AssignToAdminID, string UserID);
        IQueryable<UserModel> ShowallRoles(string sortColumn, string sortColumnDir, string Search);
        bool RemovefromUserRole(string RegistrationID);
        List<UserModel> GetListofUnAssignedUsers();
        bool SaveAssignedRoles(AssignRolesModel AssignRolesModel);
        bool CheckIsUserAssignedRole(int RegistrationID);
    }
}
