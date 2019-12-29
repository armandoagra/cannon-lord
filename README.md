# cannon-lord
Projeto desenvolvido para o teste para desenvolvedor Unity3D (Estágio BluePixel)

### 1. Como executar
O jogo pode ser executado de três formas:
Baixando o executável para PC através do link: https://drive.google.com/open?id=1EAW3j1G7fmC0Q1kGjCTwtwUN52y1Lo2R

Baixando o .apk para Android através do link: https://drive.google.com/open?id=1G3XbCpeJFRunk6jIJ21A6VDFsKpg5rHZ

Online através do link: https://armandoagra.github.io/cannon-lord-build/


### 1.1 Como jogar
Ao iniciar o jogo, é necessário clicar no botão no canto superior direito para começar a jogar. O jogador atira clicando no botão localizado no canto inferior direito.

### 2. Organização
Conforme sugerido no documento do teste, códigos modularizados seriam um ponto positivo, portanto, os códigos do jogo estão bem separados um do outro. O projeto também está organizado de forma compreensível, com pastas que agrupam arquivos de mesmo formato ou com uso similar. 

### 3. Pontos adicionais e observações
Houve o interesse de manter algumas mecânicas básicas do jogo, já que se trata de uma réplica, portanto, o canhão continua se movendo de forma automática, sendo responsabilidade do jogador apenas atirar no momento certo. A movimentação dos inimigos também ocorre de forma similar ao do jogo original.

Foi adicionado ao jogo: 
1) Efeitos sonoros - a implementação dos efeitos sonoros não foi demorada, sendo necessário apenas adicionar o componente AudioSource e escolher o momento da execução, o que demorou cerca de 5 minutos (desconsiderando o tempo de pesquisa e edição dos efeitos sonoros).
2) Sistema de partículas - foram adicionados um Trail na bala do canhão e um sistema de partículas que é executado quando um morcego é eliminado. Foi necessário cerca de 30 minutos para conseguir um resultado agradável.
3) Animação do inimigo - como não foi possível replicar o asset usado no jogo original, foi necessário utilizar um novo asset. A implementação demorou cerca de 20 minutos (e serviu como aprendizado, já que ainda não tinha mexido com SpriteSheet na Unity).
4) Painel final - o painel aparece quando o jogo acaba e mostra algumas informações. Cerca de 45 minutos para que ficasse do jeito ideal, tendo cuidado com mudanças de resolução.
5) Highscore - bem simples de fazer, armazena localmente a maior pontuação do jogador e é um dado persistente. 5 minutos.
6) Variação de inimigos - também simples de fazer, já que o código está modularizado. Só foi necessário criar novos prefabs e alterar os valores no Inspector (tamanho, velocidade, pontuação, vida). Também foi necessário fazer alterações no script que cria os monstros (MonsterSpawner) para que criasse aleatoriamente um dos monstros.
7) Feedback visual no delay do tiro - É possível ver pela cor do botão se é possível atirar ou não. Apesar de ser um conceito fácil, demorou cerca de 30 minutos.
8) (Observação) Movimentação do canhão - nessa réplica, a movimentação do canhão foi feita utilizando seno (Mathf.Sin()), dessa forma, ocorre uma certa suavização do movimento. 
