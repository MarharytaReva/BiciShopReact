import React from 'react'
import { Button, Form } from 'react-bootstrap'
import { service } from '../ApiService'

class Login extends React.Component {
    constructor(props){
        super(props)
        this.state = {
            login: '',
            password: ''
        }
       
       
    }
    componentDidMount(){
        let token = sessionStorage.getItem('access_token')
        if(token){
            this.props.history.push('/list')
        }
    }
    loginClick(){
        service.login(this.state, () => this.props.history.push('/list'))
    }
    stateChange(e){
        const { value, name } = e.target
        this.setState({
            [name]: value
        })
    }
    render() {
        return (
            <div className="centerForm">
                <div>
                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Login:</Form.Label>
                        <Form.Control type="text" name="login"
                                                  value={this.state.login}
                                                  onChange={(e) => this.stateChange(e)}
                                                  placeholder="Enter email" />
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Password:</Form.Label>
                        <Form.Control type="password"
                                      name="password"
                                      value={this.state.password}
                                      onChange={(e) => this.stateChange(e)}
                                      placeholder="Password" />
                        <Form.Text className="text-muted">
                            We'll never share your password with anyone else.
                        </Form.Text>
                    </Form.Group>

                   
                </div>
                <Button variant="primary" onClick={() => this.loginClick()}>Login</Button>
            </div>
        )
    }
}
export default Login