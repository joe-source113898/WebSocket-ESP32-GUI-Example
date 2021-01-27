#include <WiFi.h>
#include <Ticker.h>
#include <ESPAsyncWebServer.h>
#include <WebSocketsServer.h>
#include <ArduinoJson.h>

//Creación de la red Wi-Fi
const char* ssid = "FlyCUCEI";
const char* password = "INRO2017A";

//Variables globales
int pwm_value;
int potValor;
const int freq = 5000;
const int ledChannel1 = 0;
const int resolution = 8;

//Pines del hardware
const int ledPin1 = 2;
const int potPin = 34;


//Creación del servidor
AsyncWebServer server(80);
WebSocketsServer websockets(81);

Ticker timer;

void data_sent();

void webSocketEvent(uint8_t num, WStype_t type, uint8_t *payload, size_t length)
{
  switch(type)
  {
    case WStype_DISCONNECTED:
      Serial.printf("[%u] Disconnected!\n", num);
      break;
    case WStype_CONNECTED:
    {
      IPAddress ip = websockets.remoteIP(num);
      Serial.printf("[%u] Connection from ", num);
      Serial.println(ip.toString());
    }
      break;
    case WStype_TEXT:
      Serial.printf("[%u] get Text: %s\n", num, payload);
      String data_sent = String((char*)(payload));
      Serial.println(data_sent);
      StaticJsonDocument<32> doc;
      deserializeJson(doc, data_sent);
      String json_data_sent = doc["json"];
      if (json_data_sent == "on")
      {
        digitalWrite(ledPin1, HIGH);
      }
      else if (json_data_sent == "off")
      {
        digitalWrite(ledPin1, LOW);
      }
      else
      {
        pwm_value = json_data_sent.toInt();   
        ledcWrite(ledChannel1, pwm_value);
      }
      break;
  }
}

//Funciones del servidor
void notFound(AsyncWebServerRequest *request)
{
  request->send(404, "text/plain", "Page Not found");
}

void setup()
{
  Serial.begin(115200);
  //pinMode(ledPin1, OUTPUT);
  ledcSetup(ledChannel1, freq, resolution);
  ledcAttachPin(ledPin1, ledChannel1);
  WiFi.softAP(ssid, password); 
  IPAddress ip = WiFi.softAPIP();
  Serial.println("Nombre de mi red ESP32");
  Serial.println(ssid);
  Serial.println("La dirección IP es:");
  Serial.println(ip);
  server.onNotFound(notFound);
  server.begin();
  websockets.begin();
  websockets.onEvent(webSocketEvent);
  timer.attach(0.8, data_sent);
}

void loop()
{
  websockets.loop();
}

void data_sent()
{
  potValor = analogRead(potPin);
  String value = String(potValor);
  String json_data_sent = "{";
  json_data_sent += "\"json\":\""+value+"\"";
  json_data_sent += "}";
  Serial.println(json_data_sent);     
  websockets.broadcastTXT(json_data_sent);
}
