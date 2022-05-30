using Microsoft.EntityFrameworkCore;
using PCAssesmentApp.BaseResponse;
using PCAssesmentApp.Dto;
using PCAssesmentApp.EntityFrameworkCore;
using PCAssesmentApp.Models;
using PCAssesmentApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssesmentApp.Repository
{
    public class UserService : IUserService
    {
        public PCAssesmentAppDbContext _context { get; }

        public UserService(PCAssesmentAppDbContext context)
        {
            _context = context;
        }


        public async Task<BaseResponses> CreateUser(UserDto model)
        {
            try
            {
                var user = new User
                {
                    Name = model.Name,
                    Gender = model.Gender
                };
                _context.Users.Add(user);
               var val =  await _context.SaveChangesAsync();

                if (val >0)
                {
                    return new BaseResponses(true, "Success");
                }
                return new BaseResponses(false, "Failed");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BaseResponses> GetAllUser()
        {
            try
            {
                List<GetUserDto> getUserDtos = new List<GetUserDto>();
                var fetch = await _context.Users.ToListAsync();
                if (fetch.Count > 0)
                {
                    foreach (var item in fetch)
                    {
                        var AllUser = new GetUserDto
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Gender = item.Gender == Gender.Male ? "Male" : "Female"
                        };
                        getUserDtos.Add(AllUser);
                    }
                    return new BaseResponses(true, "Fixed type list", getUserDtos);
                }
                return new BaseResponses(false, "No User");
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public async Task<BaseResponses> GetSingleUser(int Id)
        {
            try
            {
                var fetch = await _context.Users.Where(r=>r.Id == Id).SingleOrDefaultAsync();
                if (fetch != null)
                {
                    var AllUser = new GetUserDto
                    {
                        Id =fetch.Id,
                        Name = fetch.Name,
                        Gender = fetch.Gender == Gender.Male ? "Male" : "Female"
                    };
                    return new BaseResponses(true, "User", AllUser);
                }
                return new BaseResponses(false, "No User");
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
