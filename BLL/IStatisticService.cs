using Interview.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interview.BLL
{
    public interface IStatisticService
    {
        int GetUsersCount(Status status);
    }
}
