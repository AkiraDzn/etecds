long cpf, cpf1, cpf2, cpf3, cpf4, cpf5, cpf6, cpf7, cpf8, cpf9, cpf10, cpf11, cpfr;
            long dig1, dig2;
            Console.Write("Qual o seu CPF? ");
            cpf = long.Parse(Console.ReadLine());
            /*Separação em cada número*/
            cpf1 = cpf / 10000000000;
            cpfr = cpf % 10000000000;
            cpf2 = cpfr / 1000000000;
            cpfr = cpfr % 1000000000;
            cpf3 = cpfr / 100000000;
            cpfr = cpfr % 100000000;
            cpf4 = cpfr / 10000000;
            cpfr = cpfr % 10000000;
            cpf5 = cpfr / 1000000;
            cpfr = cpfr % 1000000;
            cpf6 = cpfr / 100000;
            cpfr = cpfr % 100000;
            cpf7 = cpfr / 10000;
            cpfr = cpfr % 10000;
            cpf8 = cpfr / 1000;
            cpfr = cpfr % 1000;
            cpf9 = cpfr / 100;
            cpfr = cpfr % 100;
            cpf10 = cpfr / 10;
            cpfr = cpfr % 10;
            cpf11 = cpfr / 1;
            /*Verificações Simples*/
            if (cpf == 11111111111 || cpf == 22222222222 || cpf == 33333333333 || cpf == 44444444444 || cpf == 55555555555 || cpf == 66666666666 || cpf == 77777777777 || cpf == 88888888888 || cpf == 99999999999 || cpf == 00000000000)
            {
                Console.Write("{0}{1}{2}.{3}{4}{5}.{6}{7}{8}-{9}{10} não é um CPF Inválido", cpf1, cpf2, cpf3, cpf4, cpf5, cpf6, cpf7, cpf8, cpf9, cpf10, cpf11);
            }
            else
            {
                /*Fórmula do 1° Dígito*/
                dig1 = ((cpf1 * 10 + cpf2 * 9 + cpf3 * 8 + cpf4 * 7 + cpf5 * 6 + cpf6 * 5 + cpf7 * 4 + cpf8 * 3 + cpf9 * 2) * 10) % 11;
                if (dig1 == 10)
                {
                    dig1 = 0;
                }
                /* Fórmula do 2° Dígito*/
                dig2 = ((cpf1 * 11 + cpf2 * 10 + cpf3 * 9 + cpf4 * 8 + cpf5 * 7 + cpf6 * 6 + cpf7 * 5 + cpf8 * 4 + cpf9 * 3 + cpf10 * 2) * 10) % 11;
                if (dig2 == 10)
                {
                    dig2 = 0;
                }
                if (dig1 == cpf10 && dig2 == cpf11)
                {
                    Console.Write("{0}{1}{2}.{3}{4}{5}.{6}{7}{8}-{9}{10} é um CPF Válido", cpf1, cpf2, cpf3, cpf4, cpf5, cpf6, cpf7, cpf8, cpf9, cpf10, cpf11);
                }
                else
                {
                    Console.Write("{0}{1}{2}.{3}{4}{5}.{6}{7}{8}-{9}{10} não é um CPF Inválido", cpf1, cpf2, cpf3, cpf4, cpf5, cpf6, cpf7, cpf8, cpf9, cpf10, cpf11);
                }
            }
            Console.ReadKey();
