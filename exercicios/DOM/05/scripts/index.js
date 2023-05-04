function verificar(){
    var check1 = document.getElementById('chk1');
    var check2 = document.getElementById('chk2');
    var check3 = document.getElementById('chk3');
    var chkdis = document.getElementById('chkdisabled');


    if(check1.checked && check2.checked || check2.checked && check3.checked || check1.checked && check3.checked){
        chkdis.disabled = false;
    }else{
        chkdis.disabled = true;
        chkdis.checked = false;
    }

}