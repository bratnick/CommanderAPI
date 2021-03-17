using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool saveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

        //to create a resource (post stuff)
        void CreateCommand(Command cmd);

        //to update a resource (put stuff)
        void UpdateCommand(Command cmd);

        //to delete a resource
        void DeleteCommand(Command cmd);
    }
}
