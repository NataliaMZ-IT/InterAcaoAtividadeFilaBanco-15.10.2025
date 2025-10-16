# Atividade de Simulação de Atendimento em um Banco

## Cenário
O banco possui uma fila normal (clientes comuns) e uma fila prioritária (idosos, gestantes ou pessoas com deficiência).  
O sistema organiza o atendimento seguindo a regra de atender um cliente da fila prioritária para cada dois clientes da fila normal.  
O programa permite inserir clientes nas filas.  
O operador do sistema pode escolher quem será atendido a seguir, respeitando a regra acima.  
Ao ser atendido, o cliente sai da fila.  
O programa também exibe o estado atual das filas após cada operação.  

## Requisitos Técnicos
### 1. Classe `Client`:
  * `Name (string)`
  * `Age (int)`
  * `Priority (bool)`
  * `Next (Client)`

### 2. Classe `ClientQueue` que representa a estrutura de dados com dados privados:
  * `Head (Client)`
  * `Tail (Client)`
    #### _Métodos_:

    * `InsertQueue(Cliente client)` - adiciona um cliente ao final.
    * `RemoveQueue()` - remove e retorna o primeiro cliente.
    * `EmptyQueue()` - retorna true se a fila estiver vazia.
    * `ShowQueue()` - exibe todos os clientes na fila.
    
### 3. Classe `Banco`:
  * `NormalQ (ClientQueue)`
  * `PriorityQ (clientQueue)`
  * `Contador` - contador interno que controla a ordem de atendimento
    #### _Métodos_:
    
    * `AddClient(Client client)` - adiciona um cliente em uma fila baseado na sua prioridade.
    * `AtenderCliente()` - retira o próximo cliente respeitando a proporção de atendimento e exibe quem foi atendido.
    * `ShowAllQueues)` - mostra as duas filas e quem estiver nelas.

### 4. No `Main`, há um menu interativo:
  * 1 - Adicionar cliente
  * 2 - Atender próximo cliente
  * 3 - Mostrar filas
  * 4 - Sair
