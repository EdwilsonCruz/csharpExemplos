namespace _01_Estrutura
{
    public class Pilha
    {
        Posicao primeiro;
        public void Empilhar(object item){
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilhar(){
            // TODO: tratar erro qnd primeiro é null
            if (primeiro==null)
            {
                throw new System.InvalidOperationException("A pilha está vazia!");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }
        class Posicao{
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item){
                this.proximo = proximo;
                this.item    = item;
            }
        }

    }
}