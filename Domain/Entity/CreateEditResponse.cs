using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class CreateEditResponse : BaseResponse
    {
        public static readonly CreateEditResponse NotPermitted = new CreateEditResponse(
            false,
           "",
            "You don't have sufficient permissions to perform this action.");



        public CreateEditResponse(bool status,
                                  string code,
                                  string message,
                                  Guid? id = (Guid?)null,
                                  string field = "",
                                  int count = 0) : base(status,
                                                           code,
                                                           message,
                                                           field,
                                                           count)
        {
            Id = id;
        }
        public Guid? Id { get; }
    }
}
