using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    public interface ITaskRepository
    {
        /// <summary>
        /// Here the method is constructed from the interface, if the interface is used in a class 
        /// it must contain the Methods that are noted in this interface.
        /// This method doesn't have any parameters and will be used to get all of the information out of a list.
        /// </summary>
        List<Task> GetAll();

        /// <summary>
        /// Here the method is constructed from the interface, if the interface is used in a class
        /// it must contain this method with the correct parameters. 
        /// To be able to work, this method is required to have an ID parameter added to it.
        /// </summary>
        Task GetById(int id);

        /// <summary>
        /// Here the method is constructed from the interface, if the interface is used in a class
        /// it must contain this method with the correct parameters.
        /// To be able to work, this method is required to have an Task parameter added to it.
        /// Also it's making sure the method is actually working with something.
        /// </summary>
        bool Insert(Task task);

        /// <summary>
        /// Here the method is constructed from the interface, if the interface is used in a class
        /// it must contain this method with the correct parameters.
        /// To be able to work, this method is required to have an Task + ID parameter added to it.
        /// This will make sure everything for the Task will be updated when called upon.
        /// </summary>
        void Update(int id, Task task);

        /// <summary>
        /// Here the method is constructed from the interface, if the interface is used in a class
        /// it must contain this method with the correct parameters.
        /// To be able to work, this method is required to have an ID parameter added to it.
        /// This will make sure everything under the given ID row will be deleted.
        /// </summary>
        bool Delete(int id);

    }
}
