using System.Data;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository; 

namespace Kiosco_La_esquina.domain.services
{
    public class EmployeeService
    {
        private readonly Repository _repository;

        public EmployeeService()
        {
            _repository = new Repository();
        }

        /// <summary>
        /// Obtiene la lista completa de empleados desde la base de datos.
        /// </summary>
        /// <remarks>
        /// Usa el EmployeeService para consultar la tabla Employee.
        /// En caso de error, muestra un MessageBox con el mensaje correspondiente.
        /// </remarks>
        /// <returns>Una lista de objetos <see cref="Employee"/> con todos los empleados.</returns>
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                string query = "SELECT * FROM Employee";
                DataTable response = _repository.Get(query);

                foreach (DataRow row in response.Rows)
                {
                    employees.Add(new Employee
                    {
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Identifier = row["Identifier"].ToString(),
                        Email = row["Email"].ToString(),
                        Role = row["Role"].ToString(),
                        Salary = Convert.ToDecimal(row["Salary"]),
                        HireDate = Convert.ToDateTime(row["HireDate"])
                    });
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en un cartel
                MessageBox.Show(
                    "Ocurrió un error al obtener los empleados:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return employees;
        }

         
        }
    }


