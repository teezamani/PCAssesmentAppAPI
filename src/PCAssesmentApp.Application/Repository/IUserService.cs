using PCAssesmentApp.BaseResponse;
using PCAssesmentApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssesmentApp.Repository
{
    public interface IUserService
    {
        Task<BaseResponses> GetAllUser();
        Task<BaseResponses> CreateUser(UserDto userDto);
        Task<BaseResponses> GetSingleUser(int Id);

    }
}
