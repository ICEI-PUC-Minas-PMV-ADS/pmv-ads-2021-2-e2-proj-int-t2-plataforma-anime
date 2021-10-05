# Plano de Testes de Software

Para realização dos casos de teste, serão necessários alguns requisitos:

* Site já publicado
* Navegador da internet - Chrome ou Edge
* Conectividade com internet
* Massa de dados criada em banco de dados. 

Os testes funcionais serão realizados conforme descrito abaixo:
 
 
 |`CASO DE TESTE`| CT01 Login com sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-01 O site deve apresentar uma página de login para autenticação de usuários cadastrados|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha corretas.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br>Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador<br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Realizar pesquisa de animes pelos filtros citados em Requisitos Associados|
 |`CRITÉRIOS DE ÉXITO`| O usuário consegue acessar a plataforma com sucesso.|
 
 <br> <br>
 
 |`CASO DE TESTE`| CT02 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF – 07  Só terá acesso ao conteúdo do site, o usuário já cadastrado no sistema.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login inválido e senha válida <br> E-mail: naruto.top@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login errado e senha correta|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|
 
 <br> <br>
 
 |`CASO DE TESTE`| CT03 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF – 07  Só terá acesso ao conteúdo do site, o usuário já cadastrado no sistema.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login válido e senha inválida <br> E-mail: teste.animescode@gmail.com <br Senha: Tanjiro01*|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login válido e senha incorreta|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|
 
 <br> <br>
 
 |`CASO DE TESTE`| CT04 Login sem sucesso de usuário cadastrado|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF – 07  Só terá acesso ao conteúdo do site, o usuário já cadastrado no sistema.|
 |`OBJETIVO DO TESTE`| Verificar se o usuário consegue realizar o login com e-mail e senha incorretos.|
 |`MASSA DE TESTE`|Login e senha inválidos <br> E-mail: naruto.top@gmail.com <br> Senha: Tanjiro01*|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Informar login e senha inválidos|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve emitir a mensagem "e-mail ou senha incorretos"|
 
<br> <br>

 |`CASO DE TESTE`| CT05 Cadastro de novos usuários|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF - 02 O site deve apresentar um link na página de login para cadastro de novos usuários através de um formulário. Este formulário deve conter: * Nome <br> * Data de nascimento <br> * E-mail <br> * Confirmar e-mail <br> * Senha <br> * Confirmar Senha.|
 |`OBJETIVO DO TESTE`| * Verificar se o formulário de cadastro é exibido para novos usuários, quando este acessa o link. <br> * Verificar se os campos citados em *Requisitos Associados*, estão sendo exibidos corretamente. <br> * Verificar se o usuário consegue logar após o cadastro.|
 |`MASSA DE TESTE`|Será gerada durante o teste.|
 |`PASSOS`|* Acessar o Navegador Informar a Url do site <br> * Visualizar a página principal <br> * Clicar no link para cadastro de novos usuários <br> * Realizar cadastro completo <br> * Efetuar login|
 |`CRITÉRIOS DE ÉXITO`|  O sistema deve permitir o cadastro de um novo usuário e liberar o seu acesso.|
 
 <br> <br>
 
 |`CASO DE TESTE`| CT06  Verificar elementos do filtro de pesquisa|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF - 03 O site deve permitir uma pesquisa de animes possibilitando o uso dos filtros nome, gênero, autor, estúdio e nota.|
 |`OBJETIVO DO TESTE`| Verificar se o filtro está retornando os registros buscados de forma correta.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`| * Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Realizar pesquisa de animes pelos filtros citados em Requisitos Associados|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve retornar ao usuário as pesquisas de acordo com os filtros selecionados.|
 
  <br> <br>
  
 |`CASO DE TESTE`|CT07  Acompanhamento das temporadas de um anime.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-04 O site deve possibilitar que o usuário marque em qual temporada e episódio ele está.|
 |`OBJETIVO DO TESTE`| Verificar se o  radius para seleção de temporada inteira está clicável.  |
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar lista de animes <br> * Selecionar um anime <br> * Clicar no radius ao lado da temporada, para marcar como assistida.|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve reconhecer que toda a temporada foi vista com esta ação.|
 
  <br> <br>
  
 |`CASO DE TESTE`|CT08  Acompanhamento dos episódios da temporada|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-04 O site deve possibilitar que o usuário marque em qual temporada e episódio ele está.|
 |`OBJETIVO DO TESTE`|Verificar se o checkbox para seleção de um episódio dentro de uma temporada está clicável.a|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar lista de animes <br> * Selecionar um anime <br> * Clicar no checkbox para marcar o episódio.|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve reconhecer que toda a temporada foi vista com esta ação.|
 
  <br> <br>
  
 |`CASO DE TESTE`|CT09 Usuário avaliar com notas os animes assistidos. |
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF08  O usuário só pode dar nota ao anime, após finalizá-lo.|
 |`OBJETIVO DO TESTE`|Verificar se o usuário está conseguindo avaliar o anime, apenas quando todos os episódios e temporadas estão marcados como concluído.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar lista de animes <br> * Acessar lista de animes <br> * Avaliar com nota anime já marcado como finalizado.|
 |`CRITÉRIOS DE ÉXITO`| O sistema deve permitir a avaliação apenas em animes já finalizados.|
 
 <br> <br>
 
 |`CASO DE TESTE`|CT10 Alteração do status pós marcação em anime.|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-10 O usuário poderá criar uma lista de animes que está assistindo no momento e marcar seu progresso que será diferenciado por cores. Animes já assistidos em verde, os animes em andamento de amarelo, animes para assistir depois em roxo.|
 |`OBJETIVO DO TESTE`|Verificar se o usuário está conseguindo avaliar o anime, apenas quando todos os episódios e temporadas estão marcados como concluído.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Pesquisar anime <br> * Marca-lo como lido/em andamento/ver depois.|
 |`CRITÉRIOS DE ÉXITO`| O site deve possibilitar que o usuário marque as opçõeslido/em andamento/ver depois, no anime selecionado|
 
<br> <br>

 |`CASO DE TESTE`|CT12 Lista de animes em PDF|
 |:-----------:|:---------:|
 |`REQUISITOS ASSOCIADOS`|RF-11 O site deve emitir uma lista com o nome” minha lista de animes”.|
 |`OBJETIVO DO TESTE`|Gerar uma lista em PDF com animes presentes na lista do usuário.|
 |`MASSA DE TESTE`|Usuário teste cadastrado do sistema <br> Email: teste.animescode@gmail.com <br> Senha: Animescode@1|
 |`PASSOS`|* Acessar o Navegador <br> * Informar a Url do site <br> * Visualizar a página principal <br> * Realizar Login <br> * Acessar area do usuario <br> * Clicar em minha lista <br> * Gerar arquivo PDF|
 |`CRITÉRIOS DE ÉXITO`|O sistema deve emitir um arquivo em PDF com os animes adicionados a lista do usuário. |


 
