window.onload = function () {
    function send() {

        var userLogin = {
            Email: $("#un").val(),
            Password: $("#pw").val()
        };

        $.ajax({
            url: 'http://localhost:1923/Login/Login',
            type: 'post',
            dataType: 'json',
            cache: false,
            xhrFields: {
                withCredentials: true
            },
            success: function (data) {
                if (data.Auth) {
                    alert("Ви увійшли");
                    close();
                }
                else
                    alert("Логін чи пароль вказано невірно");
            },
            data: userLogin
        });
        return false;
    }
    function getUserLogin() {
        $.ajax({
            url: 'http://localhost:1923/Login/UserLogin',
            type: 'get',
            dataType: 'json',
            cache: false,
            xhrFields: {
                withCredentials: true
            },
            success: function (data) {
                $('#target').innerHTML = data.UserLogin;
                $('#target').html(data.Auth);
            }
        });
        return false;
    }
}