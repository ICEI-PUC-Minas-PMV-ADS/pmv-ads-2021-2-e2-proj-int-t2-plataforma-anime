# Arquitetura da Solução

Nesta seção são especificados os detalhes técnicos do projeto, abordando componentes relacionados a solução e também a forma como será feita a hospedagem.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![diagrama de classses](https://user-images.githubusercontent.com/78181968/134985712-8d241f6a-02c6-48f6-9997-28878f8c0aaf.jpg)


## Diagrama ER

O Diagrama Entidade Relacionamento representa como as entidades se relacionam na aplicação interativa.

![ER diagram](https://user-images.githubusercontent.com/78181968/134986086-2ce88db3-6768-4e7e-be2d-ef91a7747e25.png)

## Modelo Relacional

O Modelo Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.

- USUARIOS (<u>id_usuario</u>, nome, status, email, senha)

- LISTA_ANIMES (<u>id_lista</u>, id_usuario, id_anime, avaliacao) <br>
    id_usuario referencia USUARIOS <br>
    id_anime referencia ANIMES

- ANIMES (<u>id_anime</u>, nome, descricao, id_genero)<br>
    id_genero referencia GENERO_ANIME

- GENERO_ANIME (<u>id_genero</u>, nome, descricao)

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem


