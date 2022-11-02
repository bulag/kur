/// <reference path="JavaScript1.js" />
<html>

function   subtraction()
{
    s1=document.getElementById("sayi1").value;
    s2=document.getElementById("sayi2").value;
    sonuc.value=parseInt(s1)-parseInt(s2);
}
function   multip()
{
    s1=document.getElementById("sayi1").value;
    s2=document.getElementById("sayi2").value;
    sonuc.value=parseInt(s1)*parseInt(s2);
}
function   division()
{
    s1=document.getElementById("sayi1").value;
    s2=document.getElementById("sayi2").value;
    if(s2==0)
        alert("donomioater cant be ,change the value")
    else
        sonuc.value=parseInt(s1)/parseInt(s2);
}</script>

</head>

<body>
<b>Sayı 1:</b> <input  type="text"  id="sayi1" >
</br>
<b>Sayı 2:</b> <input  type="text"  id="sayi2" >
</br></br>
<input type="button"  id="buttonadd" value="+" onclick="addition()">
<input type="button"  id="buttonasub" value="-" onclick=" subtraction()">
<input type="button"  id="buttonamul" value="*" onclick="multip()">
<input type="button"  id="buttondiv" value="/" onclick="division()">
</br></br>
<b>Sonuç:</b> <input  type="text"  id="sonuc" >
</body>
</html>