// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code

//////проверка на корректный ввод///////

function toggleButton() {
    if ((document.contact_form.contact_name.value == "") || (document.contact_form.second_name.value == "") || (document.contact_form.phone.value == "") || (document.contact_form.email.value == "") || (document.contact_form.rate.value == "") || (document.contact_form.rate.selectedIndex == 0) || (document.getElementById("text_feedback").value == '')) {
        document.getElementById('btn').disabled = true;
    } else {
        document.getElementById('btn').disabled = false;
    }
}

function validForm() {
    var valid = true;
    var isEmail = /^[\w]{1}[\w-\.]*@[\w-]+\.[a-z]{2,4}$/;
    var isPhone = /^(\+7|7|8)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}$/;
    var isName = /^[a-zA-Zа-яА-ЯЁё -]+$/;
    var validPhone = isPhone.test(document.getElementById('id_phone').value);
    var validName = isName.test(document.getElementById('id_name').value);
    var validSecondName = isName.test(document.getElementById('id_secondname').value);
    var validEmail = isEmail.test(document.getElementById('id_email').value);
    if (!validPhone) {
        document.getElementById('message_phone').innerHTML = '*Неверный формат телефонного номера!';
        valid = false;
    } else {
        document.getElementById('message_phone').innerHTML = '';
    }
    if (!validName) {
        document.getElementById('message_name').innerHTML = '*Неверно введено имя!';
        valid = false;
    } else {
        document.getElementById('message_name').innerHTML = '';
    }
    if (!validSecondName) {
        document.getElementById('message_surname').innerHTML = '*Неверно введена фамилия!';
        valid = false;
    } else {
        document.getElementById('message_surname').innerHTML = '';
    }
    if (!validEmail) {
        document.getElementById('message_email').innerHTML = '*Неверно введен адрес электронной почты!';
        valid = false;
    } else {
        document.getElementById('message_email').innerHTML = '';
    }
    return valid;
}

//////кнопка возврата наверх///////
function up() {
    var top = Math.max(document.body.scrollTop, document.documentElement.scrollTop);
    if (top > 0) {
        window.scrollBy(0, ((top + 100) / -10));
        t = setTimeout('up()', 20);
    } else clearTimeout(t);
    return false;
}

function first() {

    document.getElementById("second_hide").setAttribute("style", "opacity:1; transition: 1s; height: 100%;");

    document.getElementById("first").setAttribute("style", "display: none");

    document.getElementById("first_yelloy").setAttribute("style", "display: block");

}

function first_yelloy() {

    document.getElementById("second_hide").setAttribute("style", "display: none");

    document.getElementById("first_yelloy").setAttribute("style", "display: none");

    document.getElementById("first").setAttribute("style", "display: block");

}

function first() {

    document.getElementById("second_hide").setAttribute("style", "opacity:1; transition: 1s; height: 100%;");

    document.getElementById("first").setAttribute("style", "display: none");

    document.getElementById("first_yelloy").setAttribute("style", "display: block");

}

function first_yelloy() {

    document.getElementById("second_hide").setAttribute("style", "display: none");

    document.getElementById("first_yelloy").setAttribute("style", "display: none");

    document.getElementById("first").setAttribute("style", "display: block");

}

function loadDoc() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML =
                this.responseText;
        }
    };
    xhttp.open("GET", "../../documents/description.txt", true);
    xhttp.send();

    document.getElementById("second_hide").setAttribute("style", "opacity:1; transition: 1s; height: 100%;");

    document.getElementById("first").setAttribute("style", "display: none");

    document.getElementById("first_yelloy").setAttribute("style", "display: block");
}