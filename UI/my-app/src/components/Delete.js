import React from 'react'
import { Button } from 'react-bootstrap'
import { service } from '../ApiService'

class Delete extends React.Component{

    constructor(props){
        super(props)
       
    }
    toList(){
        this.props.history.push('/list')
    }
    clickEvent(){
        const id = this.props.match.params.id
        service.delete(id, this.toList.bind(this))
    }
    render(){
        return(
            <div className='centerForm' style={{textAlign: 'center'}}>
                <h1>Are you shure?</h1>
                <div style={{display: 'flex', flexWrap: 'nowrap', justifyContent: 'space-around'}}>
                    <Button  variant="danger" onClick={() => this.clickEvent()}>Delete</Button>
                    <Button variant="secondary" onClick={() => this.toList()}>Cancel</Button>
                </div>
            </div>
        )
    }
}

export default Delete