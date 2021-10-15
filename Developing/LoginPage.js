function logar(){
    var userLogin = document.querySelector('input#txtUser').value
    var passwordLogin = document.querySelector('input#txtPassword').value
    console.log(userLogin)
    console.log(passwordLogin)

    var userCadastrado = "igor giovane"
    var senhaCadastrada = "igorGG10"

    if (userCadastrado == userLogin && senhaCadastrada == passwordLogin) {
        alert('Login feito com sucesso')
    } 
    
    else{ 
        alert("Dados de login incorretos")
    }
}