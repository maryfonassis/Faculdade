using ExercicioRobson09._03;
Aluno aluno = new Aluno(1111, "Mariany", 19);
Professor professor = new Professor(222, "Robson", "TI");
Diciplina diciplina = new Diciplina(333, "PO", 20.0);
Nota nota = new Nota(4.0, 8.0, 2.5);
Boletim boletim = new Boletim(aluno, professor, diciplina, nota);

Console.WriteLine(boletim);
;