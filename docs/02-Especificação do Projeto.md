# Especificações do Projeto

### Personas

| `Persona` | `Idade` | `Descrição` | `Plataformas e apps utilizados` | `Motivações` | `Frustrações`  |  `Hobbies` |
|:-----------:|:---------:|:-------------:|:---------------------------------:|:--------------:|:----------------:|:------------:|
|Carlos Eduardo|15|Estudante do ensino médio. Gosta de jogos online e possui facilidade para uso de internet.|Instagram, Netflix, Amazon Prime, Crunchyroll, Youtube|Acompanhar de forma organizada os animes que está assistindo e conhecer novos animes.|Ficar perdido quanto ao episódio  que está no momento.|Filmes e séries, taekwondo|
|Maria Julia|29| Fisioterapeuta, apaixonada por animes de suspense, faz uso computador no dia a dia, possui facilidade para o uso da internet.|Instagram, Netflix, Animes Fire, Uber, Ifood|Conseguir filtrar os melhores animes de acordo com o gênero que ela mais gosta, suspense e conhecer novos animes|Conseguir feedbacks reais a respeito da qualidade dos animes.|Caminhadas ao ar livre e Ir ao cinema|
|Ana Laura|19|Auxiliar de estoque, possui uma rotina intensa de trabalho, precisando se organizar dentro das suas atividades. Informa aptidão no uso da internet.|Instagram, Netflix, Nubank, Twitter, Ifood|Encontrar um lugar onde eu consiga interagir com outros usuários dando notas para meus animes favoritos.|Não consigo encontrar um local exclusivo para catalogar e falar sobre animes.|Ir a restaurantes e Ouvir músicas|
|João Paulo|45|Analista de sistemas em empresa de grande porte, otaku. Trabalha diariamente com tecnologia, por isso tem facilidade no uso da internet.|Facebook, Amazon Prime, Inter, Twitter, Ifood|Ter acesso a uma plataforma onde fosse possível catalogar os animes que já assisti.|Não tenho a possibilidade de fazer uma lista de animes para assistir no futuro.|Estudar inglês, andar de bicicleta, maratonar meus animes favoritos|


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Eu, Carlos Eduardo|quero marcar em qual episódio da temporada e em qual temporada de um determinado anime eu estou|para conseguir me organizar com os muitos títulos que assisto e não me perder nos episódios.|
|Eu, Maria Julia|quero conseguir ver feedbacks de vários animes| para encontrar novas obras para acompanhar.|
|Eu Ana Laura| desejo criar uma lista e catalogar as obras que venho assistindo e interagir com demais usuários| para me organizar melhor e trocar experiências com outras pessoas | 
|Eu, João Paulo|desejo ter a possibilidade de criar  listas com animes que desejo assistir|para que futuramente eu possa seguir minha lista e assistir os animes que desejo.|
|Eu, Lucas Silva|desejo ter a possibilidade de compartilhar minha lista de anime com os meus amigos e filhos|para conhecer novos animes e também acompanhar o que meus amigos estão assistindo.|  

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O site deve apresentar uma página de login para autenticação de usuários cadastrados.| `ALTA` | 
|RF-02| O site deve apresentar um link na página de login para cadastro de novos usuários através de um formulário. <br> Este formulário deve conter: <br> * Nome <br> * Data de nascimento <br> * E-mail <br> * Confirmar e-mail <br> * Senha <br> * Confirmar Senha.| `ALTA`  |
|RF-03| O site deve permitir uma pesquisa de animes possibilitando o uso dos filtros nome, gênero, autor, estúdio e nota| `ALTA`  |
|RF-04| O site deve possibilitar que o usuário marque em qual episódio da temporada e em qual temporada ele está.| `ALTA`|
|RF-05| O site deve permitir que o usuário avalie as obras que desejar.| `ALTA`|
|RF-06| Só terá acesso ao conteúdo do site, o usuário já cadastrado no sistema.|`ALTA`|
|RF-07| Para definição da lista de animes, o usuario poderá selecionar apenas animes previamente cadastrados na plataforma.|`ALTA`|
|RF-08| O usuario só pode avaliar o anime, após finaliza-lo ou caso já tenha assistido.|`ALTA`|
|RF-09| Para definição da lista de animes, o usuario poderá selecionar apenas animes previamente cadastrados na plataforma.|`ALTA`|
|RF-10| O usuário poderá criar uma lista de animes que está assistindo no momento e marcar seu progresso que será diferenciado por cores.  Animes já assistidos *em verde*, os animes em andamento *de amarelo*, animes para assistir depois *em roxo.*| `MÉDIA` |
|RF-11| O site deve permitir que o usuário crie uma lista de animes com os descritores *finalizado, em andamento e assistir depois* | `MÉDIA` |
|RF-12| O site deve emitir uma lista com o nome” minha lista de animes”. | `MÉDIA` |
|RF-13|O site deverá conter sinopse dos animes.| `BAIXA` |

### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| As informações cadastrais do usuário devem estar disponíveis apenas para o usuário e o administrador do sistema |`ALTA`| 
|RNF-02| O site deverá utilizar tecnologias Front-end como HTML, CSS e Java|`ALTA`| 
|RNF-03| O site deverá utilizar a linguagem C# para estruturar o Back - End|`ALTA`|
|RNF-04|O site deve ser compatível com os navegadores Chrome e Explorer|`MEDIA`|
|RFN-05|O layout do site deverá trabalhar com um esquema de cores que atenda visualmente o usuário portador de daltonismo|`BAIXA`|
|RFN-06|O site deverá atender aos requisitos de leitores de tela para ser acessível para deficientes visuais|`BAIXA`|
|RFN-07|O site deverá ser responsivo, permitindo a visualização em um celular de forma adequada.|`BAIXA`|

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01|O projeto deverá ser entregue funcionando no final do semestre letivo, sem ultrapassar a data 15/12/2021.|
|RE-02|A equipe não pode subcontratar o desenvolvimento do trabalho|
|RE-03|A equipe desenvolverá o projeto com os integrantes que compõem o grupo e todos deverão estar cientes sobre as funcionalidades do código e sistema/website.|


## Diagrama de Casos de Uso

A seguir encontram-se os Casos de Uso e o Diagrama de Casos de Uso.

| Caso de Uso| Descrição|
|:-----------:|:---------:|
|Fazer login|Recebe as credenciais já cadastradas do usuário e em seguida é encaminhado para Verificar Credenciais.|
|Verificar Credenciais|Verifica e valida as credenciais do usuário. Caso estejam incorretas então o sistema irá exibir erro de login.|
|Avaliar animes|Registra a avaliação feita pelo usuário em determinada obra.|
|Marcar episódios/temporadas|Registra as informações sobre o progresso do usuário em determinada obra. Exemplo: episódios vistos e temporadas finalizadas.|
|Pesquisar animes|Exibir os resultados de acordo com a busca do usuário.|
|Criar sua lista|Salva as obras que o usuário já tenha assistido, está assistindo ou queira assistir, podendo adicionar ou excluir determinadas obras a qualquer momento.|
|Filtrar Preferências |Filtra o conteúdo de acordo com as preferências do usuário.|
|Listar Animes|Os animes serão adicionados e receberão as seguintes referências: sinopse, ano de lançamento, número de temporadas e episódios.|
|Excluir animes|Os animes poderão ser excluídos do site pelo administrador.|

|Ator|Descrição|
|:-----------:|:---------:|
|Otaku|Público-alvo da aplicação, ou seja, o usuário.|
|Administrador|Gerencia o conteúdo existente na página.|


![image](https://user-images.githubusercontent.com/78831493/134986218-863488d7-1f09-4705-8b7e-614f0b4356a8.png) <br>
                     *Figura 1: Representação do Diagrama de Casos de Uso
                                Fonte: elaborado pelos autores*

