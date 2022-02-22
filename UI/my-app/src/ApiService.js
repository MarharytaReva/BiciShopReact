


class BiciService {

  constructor() { 
      this.url = 'https://localhost:44364'
  }
  
    async login(loginData, func){
      let tokenUrl = this.url + '/api/account/token'
      
      let response = await fetch(tokenUrl, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(loginData)
      })
      
    

      let responseData = await response.json()
      if (response.ok === true) {
          sessionStorage.setItem('access_token', responseData.access_token)
          func()
      } 
    }
     
    
    
    postOrPut(bici, func){
      if(bici.bicicletaId == 0){
        return this.post(bici, func)
      } else{
        return this.put(bici, func)
      }
    }
    post(bici, func){
      let postUrl = this.url + '/bicis'
      let token = sessionStorage.getItem('access_token')
      fetch(postUrl, {
        method: 'POST',
        headers: {
            'Accept': 'application/json', 'Content-Type': 'application/json',
            'Authorization': 'bearer ' + token
        },
        body: JSON.stringify(bici)
      })
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        func()
      });
     
    }
    put(bici, func){
      console.log(bici)
      let putUrl = this.url + '/bicis'
      let token = sessionStorage.getItem('access_token')
      fetch(putUrl, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json', 'Content-Type': 'application/json',
            'Authorization': 'bearer ' + token
        },
        body: JSON.stringify(bici)
      })
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        console.log(data)
        func()
      });
     
    
    }
     getAll(func){
      let getAllUrl = this.url + '/bicis'
      let token = sessionStorage.getItem('access_token')
      fetch(getAllUrl, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'bearer ' + token
        }
      })
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        func(data)
      });
     
    }
     getBici(id, func){
      let getUrl = this.url + '/bicis/' + `${id}`
      let token = sessionStorage.getItem('access_token')
      fetch(getUrl, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'bearer ' + token
        }
      })
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        func(data)
      });
      
     
    }
     delete(id, func){
      let deleteUrl = this.url + '/bicis/' + `${id}`
      let token = sessionStorage.getItem('access_token')
      fetch(deleteUrl, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'bearer ' + token
        }
      })
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        func()
      });
     
     
    }
}

const service = new BiciService()
export { service }