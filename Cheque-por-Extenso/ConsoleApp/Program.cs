using ChequeExtenso;

var cheque = new Cheque();

var dec = 0.01m;

while (cheque.ChequePorExtenso(dec) != "Valor não suportado")
{
    Console.WriteLine(cheque.ChequePorExtenso(dec));
    dec += 0.01m;
}
