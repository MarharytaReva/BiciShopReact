import React from 'react'
import { Button, Form } from 'react-bootstrap'
import { service } from '../ApiService'


class CreateBici extends React.Component {

    constructor(props){
        super(props)
        this.id = props.match.params.id
        this.state = {
            bici: {
                title: '',
                price: '',
                weight: '',
                issueYear: '',
                color: '',
                wheelDiameter: '',
                biciTypeId: 1,
                bicicletaId: this.id,
                photo: "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"

            }
        }
       
        this.setBici = this.setBici.bind(this)
        this.back = this.back.bind(this)
    }
    back(){
        this.props.history.push('/list')
    }
    save(){
        service.postOrPut(this.state.bici, this.back)
    }
    setBici(bici){
        this.setState({
            bici: {
                ...bici
            }
        })
    }
    propChange(e){
        const { name, value } = e.target
        this.setState(prev => {
            return {
            bici: {
                ...prev.bici,
                [name]: value
            }
            }
        })
    }
    componentDidMount(){
       
        if(this.id != 0){
            service.getBici(this.id, this.setBici)
        }
    }
   
    render() {
        return (
            <div className="centerForm">
                <Form>
                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Title</Form.Label>
                        <Form.Control type="text"
                        name="title"
                        value={this.state.bici.title}
                        onChange={(e) => this.propChange(e)}
                         placeholder="Enter title" />
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Price</Form.Label>
                        <Form.Control type="number" placeholder="Enter price" 
                         name="price"
                         value={this.state.bici.price}
                         onChange={(e) => this.propChange(e)}/>
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Weight</Form.Label>
                        <Form.Control type="number" placeholder="Enter weight"
                         name="weight"
                         value={this.state.bici.weight}
                         onChange={(e) => this.propChange(e)} />
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Issue year</Form.Label>
                        <Form.Control type="number" placeholder="Enter issue year"
                         name="issueYear"
                         value={this.state.bici.issueYear}
                         onChange={(e) => this.propChange(e)} />
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Color</Form.Label>
                        <Form.Control type="text" placeholder="Enter color"
                         name="color"
                         value={this.state.bici.color}
                         onChange={(e) => this.propChange(e)} />
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicEmail">
                        <Form.Label>Wheel diameter</Form.Label>
                        <Form.Control type="number" placeholder="Enter wheel diameter"
                         name="wheelDiameter"
                         value={this.state.bici.wheelDiameter}
                         onChange={(e) => this.propChange(e)} />
                        <Form.Text className="text-muted">
                            We'll never share your email with anyone else.
                        </Form.Text>
                    </Form.Group>

                   
                    <Button variant="success" onClick={() => this.save()}>Save</Button>
                </Form>
            </div>
        )
    }
}

export default CreateBici