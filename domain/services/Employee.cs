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

        /// <summary>
        /// Agrega un nuevo empleado a la base de datos.
        /// </summary>
        /// <param name="employee">Objeto <see cref="Employee"/> con los datos del nuevo empleado.</param>
        /// <returns>True si se insertó correctamente; false en caso de error.</returns>
        public bool AddEmployee(Employee employee)
        {
            try
            {
                string query = $@"
            INSERT INTO Employee (FirstName, LastName, Identifier, Email, Role, Salary, HireDate)
            VALUES (
                '{employee.FirstName.Replace("'", "''")}',
                '{employee.LastName.Replace("'", "''")}',
                '{employee.Identifier.Replace("'", "''")}',
                '{employee.Email.Replace("'", "''")}',
                '{employee.Role.Replace("'", "''")}',
                {employee.Salary},
                #{employee.HireDate:MM/dd/yyyy}#)"; // Access usa # para fechas

                int rowsAffected = _repository.Execute(query);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar empleado:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }



    }
}


