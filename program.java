package MeuLaco;

public class program {

    public static void main(String[] args) {

      int alvernaria = 0;
        int vinil = 1;
        int fibra =2;
        int plastico =3;

        double area = 100;
        int tipo = alvernaria;

        System.out.println("Material\tvalor");

        while (tipo <=plastico){
            System.out.println(tipo + "\t\t" + "val" + area + tipo);
            tipo = tipo+1;

        }
    }
}
