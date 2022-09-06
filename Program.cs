Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

    string nomeCompleto, primeiroNome, segundoNome, dominio = "@fatec.sp.gov.br";
    int pos1, pos2;

    Console.Write("Digite seu nome completo: ");
    nomeCompleto = Console.ReadLine()
    .Replace("das","").Replace("dos","")
    .Replace("da","").Replace("do","")
    .Replace("'","").Replace("de","")
    .Replace("á","a").Replace("â","a")
    .Replace("é","e").Replace("ê","e")
    .Replace("í","i").Replace("î","i")
    .Replace("ó","o").Replace("ô","o")
    .Replace("ú","u").Replace("û","u");
    
pos1 = nomeCompleto.IndexOf(" ");

pos2 = nomeCompleto.LastIndexOf(" ");

primeiroNome = nomeCompleto.Substring(0,pos1);

segundoNome = nomeCompleto.Substring(pos2);

Console.WriteLine("E-mail institucional: " + primeiroNome.Trim().ToLower() + "."+ segundoNome.Trim().ToLower() + dominio);