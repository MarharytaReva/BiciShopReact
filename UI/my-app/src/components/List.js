import React from 'react'
import { service } from '../ApiService'
import CardComp from './CardComp'
import { Button } from 'react-bootstrap'
import { Link } from 'react-router-dom'

class List extends React.Component {

    constructor(props) {
        super(props)
        this.state = {
            bicis: []
        }
        this.setBicis = this.setBicis.bind(this)
    }
    setBicis(data) {
        let displayList = data.map(item => {
            return <CardComp bici={item} key={item.bicicletaId}></CardComp>
        })
        this.setState({
            bicis: displayList
        })
    }
    componentDidMount() {
        service.getAll(this.setBicis)
    }
    render() {
        return (
            <div>
                <Button variant="dark" as={Link} to="/create/0">Create</Button>
                <div className="flex">
                    {this.state.bicis}
                </div>
            </div>

        )
    }
}
export default List