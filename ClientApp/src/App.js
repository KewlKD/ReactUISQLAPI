import { useEffect, useState } from "react";


const App = () => {

const [employees, setEmployees] = useState([])

    useEffect(() => {
        fetch("api/employee/Employees")
            .then(response => { return response.json() })
            .then(responseJson => {

                setEmployees(responseJson)
            })

    },[])

    return (
        <div className="container">
            <h1>Employees</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table classname="table table-striped">
                        <thead>
                        <tr>
                                <th>Employeeid</th>
                                <th>EmployeeName</th>
                                <th>EmployeeAdd</th>
                                <th>EmployeeEmail</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            employees.map((item) => (
                              <tr>
                                <td>{item.Employeeid}</td>
                                <td>{item.EmployeeName}</td>
                                <td>{item.EmployeeAdd}</td>
                                <td>{item.EmployeeEmail}</td>
                             </tr>

                                ))
                            }
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        )
}

export default App;