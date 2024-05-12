using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Models
{
    //Entity Model
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public int Wage { get; set; }
        public bool MaritalStatus { get; set; }

        #region Implicit:means that you can convert an object of one type to another type without explicitly specifying it.
        public static implicit operator EmployeeCreateViewModel(Employee model)
        {
            return new EmployeeCreateViewModel
            {
                Name = model.Name,
                Surname = model.Surname,
                
            };
        }
        public static implicit operator Employee(EmployeeCreateViewModel model)
        {
            return new Employee
            {
                Name = model.Name,
                Surname = model.Surname,
            
            };
        }
        #endregion

    }
}
