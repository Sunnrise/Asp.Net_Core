using AutoMapper;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.AutoMappers
{
    public class EmployeeProfile: Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeCreateViewModel>();
            CreateMap<EmployeeCreateViewModel, Employee>();


        }
    }
}
