using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgotPasswordService.Repository
{
    public interface IAccount
    {
        public Task<string> GetAccount(string accountId); 
    }
}
