namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    //controller bliver altså slettet fra EmployeeController, så jeg skal 
    //skrive api/Employee/GetEmployees
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
            Id = "24",
            Name = "Peter Jensen",
            Email = "peje@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "it"
            }
        },
        new Employee() {
            Id = "25",
            Name = "Anna Nielsen",
            Email = "anni@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "it"
            }
        },
        new Employee() {
            Id = "26",
            Name = "Thomas Larsen",
            Email = "thla@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "it"
            }
        },
        
        // NYE ansatte i Kantinen
        new Employee() {
            Id = "27",
            Name = "Maria Andersen",
            Email = "maan@ibas.dk",
            Department = new Department() {
                Id = 4,
                Name = "kantinen"
            }
        },
        new Employee() {
            Id = "28",
            Name = "Lars Pedersen",
            Email = "lape@ibas.dk",
            Department = new Department() {
                Id = 4,
                Name = "kantinen"
            }
        }
        };
            return employees;
        }
    }


}