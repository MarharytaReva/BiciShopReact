import { Card, Button } from 'react-bootstrap'
import { Link } from 'react-router-dom'

function CardComp(props) {
    return (
        <Card style={{ width: '18rem' }}>
            <Card.Img variant="top" src={`data:image/png;base64, ${props.bici.photo}`} />
            <Card.Body>
                <Card.Title>{props.bici.title}</Card.Title>
                <Card.Text>Price: {props.bici.price} ₴</Card.Text>
                <Card.Text>Issue year: {props.bici.issueYear}</Card.Text>
                <Card.Text>Color: {props.bici.color}</Card.Text>
                <Card.Text>Weight: {props.bici.weight}</Card.Text>
                <Card.Text>Wheel diameter: {props.bici.wheelDiameter}</Card.Text>
                
                <Button variant="warning" as={Link} to={`/create/${props.bici.bicicletaId}`}>Edit</Button>{' '}
                <Button variant="danger" as={Link} to={`/delete/${props.bici.bicicletaId}`}>Delete</Button>
            </Card.Body>
        </Card>
    )
}

export default CardComp