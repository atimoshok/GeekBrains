package solid.lsp;

public class ClientOrder extends Order{
    public ClientOrder(int price, int qnt) {
        super(price, qnt);
    }

    public int getAmount() {
        return qnt * price;
    }
}
