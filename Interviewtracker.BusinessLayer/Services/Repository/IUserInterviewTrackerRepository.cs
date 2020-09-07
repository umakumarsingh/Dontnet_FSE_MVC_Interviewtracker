﻿using Interviewtracker.DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services.Repository
{
    public interface IUserInterviewTrackerRepository
    {
        //List of method to perform all User related operation
        Task<ApplicationUser> Register(ApplicationUser user);
        Task<ApplicationUser> GetUserById(int userId);
        Task<IEnumerable<ApplicationUser>> GetAllUser();
        IEnumerable<ApplicationUser> GetUser();
        Task<bool> DeleteUserById(int UserId);
        Task<ApplicationUser> UpdateUser(ApplicationUser user);
    }
}
