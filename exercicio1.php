<?php
$nome=$_POST['txt_nome'];
$end=$_POST['txt_end'];

$enome = substr_count($nome," ");
$eend = str_word_count($end, 0, " ");
    echo $nome."<br>tem: ".$enome." palavras<br>";
    echo $end."<br>tem: ".$eend." espaços<br>";







?>