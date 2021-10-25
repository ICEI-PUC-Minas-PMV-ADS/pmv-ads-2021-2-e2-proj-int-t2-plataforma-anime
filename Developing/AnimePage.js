var tituloAnime = "Akame ga Kill"
document.getElementById("titulo-anime").innerHTML = tituloAnime

function pesquisar(){
    var dadosSearchBar =  document.getElementById("searchBar").value
}

//Detalhes do anime

var exibirGeneros = "Ação, Aventura, Drama, Fantasia"
document.getElementById("txt-do-genero").innerHTML = exibirGeneros

var exibirAutor = "Takahiro"
document.getElementById("txt-do-autor").innerHTML = exibirAutor

var exibirStudio = "White Fox"
document.getElementById("txt-do-studio").innerHTML = exibirStudio

var exibirTemporada = "1"
document.getElementById("txt-da-temporada").innerHTML = `${exibirTemporada} Temporada(s)`

var exibirEpisodios = "24"
document.getElementById("txt-dos-episodios").innerHTML = `${exibirEpisodios} Episódios`
