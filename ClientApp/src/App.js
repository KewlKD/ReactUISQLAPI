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
                <div className="col -sm-12">
                    <table classname="table table-striped">
                        <thead>
                        <tr>
                            <th>EmployeeID</th>
                            <th>Name</th>
                            <th>Department</th>
                            <th>Date Of Joining</th>
                            <th>PhotoName</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            employees.map((item) => (
                              <tr>
                                <td>{item.EmployeeId}</td>
                                <td>{item.EmployeeName}</td>
                                <td>{item.Department}</td>
                                <td>{item.DateOfJoining}</td>
                                <td>{item.PhotoFileName}</td>
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