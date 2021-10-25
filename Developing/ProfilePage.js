function pesquisar(){
   var dadosSearchBar = document.getElementById("searchBar").value
}

var nomeDoAnimeModal = "Akame ga Kill"
document.getElementsByClassName("nome-do-anime")[0].innerHTML = nomeDoAnimeModal

function amarzenarProgresso(){

    var statusDoProgresso = document.getElementById("status-progresso").value
    var temporadaAtual = document.getElementById("temporada-atual").value
    var episodioAtual = document.getElementById("episodio-atual").value
}


document.getElementsByClassName("nick-usuario")[0].innerHTML = "MegazordFamosin"

var listaDeAnime = []

for (i = 0; i < listaDeAnime.length; i++) {
    document.write("<img id=exibiPosteresAnime src=" + listaDeAnime[i] + ">")
}

// Abrir e fechar o modal

function iniciaModal (modalID) {
    const modal = document.getElementById(modalID)
    modal.classList.add('mostrar')
    modal.addEventListener('click', function fecharModal(e){
        if(e.target.id == modalID || e.target.className == "button-fechar") {
            modal.classList.remove("mostrar")
        }
    })
}

const posterAnime = document.getElementById("exibiPosteresAnime")

exibiPosteresAnime.addEventListener("click" ,function(){
    iniciaModal("modalProgresso")
}) 
