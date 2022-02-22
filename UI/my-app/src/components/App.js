import React from 'react'
import Delete from './Delete'
import List from './List'
import Login from './Login'
import CreateBici from './CreateBici'
import {Route, Link, BrowserRouter as Router} from 'react-router-dom'

class App extends React.Component{
    constructor(){
         super()

    }
    render(){
        return(
            <Router>
                <Route exact path="/" component={Login}></Route>
                <Route path="/list" component={List}></Route>
                <Route path="/delete/:id" component={Delete}></Route>
                <Route path="/create/:id" component={CreateBici}></Route>
            </Router>
        )
    }
}

export default App