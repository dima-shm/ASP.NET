<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_2b.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="http://localhost:45002/modernizr_ws.js">
        var ta;
        var ws = null;
        var bstart;
        var bstop;

        window.onload = function () {
            if (Modernizr.websockets) {
                WriteMessage('support', 'да');
                ta = document.getElementById('ta');
                bstart = document.getElementById('bstart');
                bstop = document.getElementById('bstop');
                bstart.disabled = false;
                bstop.disabled = true;
            }
        }

        function WriteMessage(idspan, txt) {
            var span = document.getElementById(idspan);
            span.innerHTML = txt;
        }

        function exe_start() {
            if (ws == null) {
                ws = new WebSocket('ws://localhost:45002/Websokets.websocket');
                ws.onopen = function () { ws.send('Соединение'); }
                ws.onclose = function (s) { console.log('onclose', s); }
                ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
                bstart.disabled = true;
                bstop.disabled = false;
            }
        }

        function exe_stop() {
            ws.close(3001, 'stopapplication');
            ws = null;
            bstart.disabled = false;
            bstop.disabled = true;
        }
    </script>
</head>
<body>
    <section style="width: 800px; float:left;">
        <div id="wsproperties">
            Web Sockets поддерживатеся?:
            <span id="support"></span><br />
        </div>
    </section>
    <br />
    <section style="width: 215px; border:solid;">
        <div style="margin: 5px 5px 5px 5px;">
            <input id="bstart" type="button" value="Пуск"
                onclick="exe_start" style="width: 100px" />
            <input id="bstop" type="button" value="Стоп"
                onclick="exe_stop" style="width: 100px" />
            <textarea id="ta" rows="20" cols="25"
                style="text-align:center;" ></textarea>
        </div>
    </section>
</body>
</html>
