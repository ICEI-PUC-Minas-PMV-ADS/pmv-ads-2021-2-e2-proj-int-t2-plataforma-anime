# Especificações do Projeto

### Personas

| `Persona` | `Idade` | `Descrição` | `Plataformas e apps utilizados` | `Motivações` | `Frustrações`  |  `Hobbies` |
|:-----------:|:---------:|:-------------:|:---------------------------------:|:--------------:|:----------------:|:------------:|
|Carlos Eduardo|15|Estudante do ensino médio. Gosta de jogos online e possui facilidade para uso de internet.|Instagram, Netflix, Amazon Prime, Crunchyroll, Youtube|Acompanhar de forma organizada os animes que está assistindo e conhecer novos animes.|Ficar perdido quanto ao episódio  que está no momento.|Filmes e séries, taekwondo|
|Maria Julia|29| Fisioterapeuta, apaixonada por animes de suspense, faz uso computador no dia a dia, possui facilidade para o uso da internet.|Instagram, Netflix, Animes Fire, Uber, Ifood|Conseguir pesquisar os melhores animes de acordo com o gênero que ela mais gosta, e conhecer novos animes|Conseguir feedbacks reais a respeito da qualidade dos animes.|Caminhadas ao ar livre e Ir ao cinema|
|Ana Laura|19|Auxiliar de estoque, possui uma rotina intensa de trabalho, precisando se organizar dentro das suas atividades. Informa aptidão no uso da internet.|Instagram, Netflix, Nubank, Twitter, Ifood|Encontrar um lugar onde possa dar notas para seus animes favoritos.|Não consegue encontrar um local para descobrir outros animes e visualizar suas notas.|Ir a restaurantes e Ouvir músicas|
|Pedro Ferraz|18|Estudante do pré-vestibular, fã de animes, curte programação.|Instagram, Netflix, YouTube|Colocar em prática estudos de programação e criar uma aplicação para gerenciar seus animes favoritos.|Falta de um local voltado para catalogar e descobrir animes.| Jogar vídeo game e assitir séries.| 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Eu, Carlos Eduardo|quero marcar em qual episódio/temporada de um determinado anime eu estou|para conseguir me organizar com os vários títulos que assisto e não me perder nos episódios.|
|Eu, Maria Julia|quero conseguir ver a nota de vários animes| para encontrar novos animes para acompanhar.|
|Eu Ana Laura| desejo criar uma lista e catalogar os animes que venho assistindo e dar nota a eles| para que eu e outros usuários descubram novos animes. | 
|Eu, Pedro Ferraz|desejo criar uma aplicação capaz de catalogar e gerenciar animes|para fixar meu aprendizado adquiridos em cursos de programação.|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O aplicativo deve apresentar uma tela de login para autenticação de usuários cadastrados.| `ALTA` | 
|RF-02| O aplicativo deve apresentar um botão na tela de login para cadastro de novos usuários através de um formulário. <br> Este formulário deve conter: <br> * Nome <br> * Data de nascimento <br> * E-mail <br> * Senha <br>.| `ALTA`|
|RF-03| O acesso a lista de animes será permitido apenas, a usuário previamente cadastrados no aplicativo.|`ALTA`|
|RF-04| O aplicativo deverá apresentar uma tela home com imagem e nota do anime. Para visualizar essa tela o usuário não precisa estar logado. Ao clicar na imagem do anime, ele irá exibir outra tela com as informações de sinopse e temporadas.|`ALTA`|
|RF-05| O usuário poderá criar uma lista de animes que está assistindo no momento e salvar seu progresso que será diferenciado por listas sendo elas "assitidos", "em andamento" e "assitir depois".| `ALTA` |
|RF-06|O aplicativo deverá consumir de uma API as informações referentes ao anime.| `ALTA` |
|RF-07|O aplicativo deverá possibilitar um mecanismo de busca.|`MÉDIA`|
|RF-08|O aplicativo deve possibilitar a avaliação de animes.|`BAIXO`|

### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01|As informações cadastrais do usuário devem estar disponíveis apenas para o usuário.|`ALTA`| 
|RNF-02|O site deverá utilizar tecnologias Front-end como HTML, CSS e JavaScript|`ALTA`| 
|RNF-03|O site deverá utilizar a linguagem C# para estruturar o Back - End|`ALTA`|
|RNF-04|O aplicativo deve ser compatível com os sistemas operacionais Android e IOS.|`ALTA`|
|RFN-05|O layout do aplicativo deverá trabalhar com um esquema de cores que atenda visualmente o usuário portador de daltonismo|`BAIXA`|
|RFN-06|O aplicativo deverá atender aos requisitos de leitores de tela para ser acessível para deficientes visuais|`BAIXA`|

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01|O projeto deverá ser entregue funcionando no final do semestre letivo, sem ultrapassar a data 22/06/2022.|
|RE-02|A equipe não pode subcontratar o desenvolvimento do trabalho|
|RE-03|A equipe desenvolverá o projeto com os integrantes que compõem o grupo e todos deverão estar cientes sobre as funcionalidades do código e sistema/website.|


## Diagrama de Casos de Uso

A seguir encontram-se os Casos de Uso e o Diagrama de Casos de Uso.

| Caso de Uso| Descrição|
|:-----------:|:---------:|
|Cadastro de novo usuário|Cadastra um novo usuário, caso o usuário já esteja cadastrado no aplicativo, deve retornar a mensagem "Usuário já cadastrado" |
|Fazer login|Recebe as credenciais já cadastradas do usuário e em seguida é encaminhado para Verificar Credenciais.|
|Verificar Credenciais|Verifica e valida as credenciais do usuário. Caso estejam incorretas então o sistema irá exibir erro de login.|
|Avaliar animes|Registra a avaliação feita pelo usuário em determinada obra.|
|Marcar episódios/temporadas|Registra as informações sobre o progresso do usuário em determinada obra. Exemplo: episódios vistos e temporadas finalizadas.|
|Pesquisar animes|Exibir os resultados de acordo com a busca do usuário.|
|Criar sua lista|Salva as obras que o usuário já tenha assistido, está assistindo ou queira assistir, podendo adicionar ou excluir determinadas obras a qualquer momento.|

|Ator|Descrição|
|:-----------:|:---------:|
|Usuário sem cadastro|Poderá ter acesso aos animes, sinopse e notas, porém não pode criar lista de animes.|
|Usuário com cadastro|Poderá ter acesso aos animes, sinopse e notas, e poderá criar lista de animes.|
|API|Irá fornecer as informações sobre os animes para o aplicativo.|

![Diagrama de caso de uso PUC - Diagrama de caso de uso (5)](https://user-images.githubusercontent.com/78181968/157550032-0b362ae1-cae0-4317-a0bc-d78feb7664a3.png)

 <br>
 
                                                    Figura 1: Representação do Diagrama de Casos de Uso
                                                              Fonte: elaborado pelos autores 
                                
                                
## Matriz de Rastreabilidade de Requisitos                                 
## Gerenciamento e Planejamento de Cronograma, Custos e Pessoal do Projeto
