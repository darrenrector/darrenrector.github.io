#include "DHT.h"
#include <LiquidCrystal_I2C.h> 
LiquidCrystal_I2C lcd(0x27, 16, 2);

#define DHTPIN 2 // sensor's Data pin
#define DHTTYPE DHT22 // sensor type
#define SOILSENSOR A0 //soil moisture sensor analog pin
#define PUMPPIN 3 //water pump pin
#define DRYNESS 300 //set low soil moisture level
#define WATERDELAY 1500 //if soil moisture is below DRYNESS level trigger pump for 15 seconds
#define WATERPOSTDELAY 6000 //wait 60 seconds beofre taking another soil moisture reading

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  pinMode(SOILSENSOR, INPUT);
  pinMode(PUMPPIN, OUTPUT);
  
  // initialize the LCD
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("Initializing...");

  dht.begin();
}

void loop() {
  int sensorValue = analogRead(SOILSENSOR);
  Serial.print(sensorValue); Serial.print(" - ");

  if(sensorValue <= DRYNESS) 
  {
   // if the soil is too dry start watering for 1.5 seconds then
   // wait for seconds before monitoring again
   Serial.println("Soil dry start watering");
   digitalWrite(PUMPPIN, HIGH);
   delay(WATERDELAY);
   digitalWrite(PUMPPIN, LOW);
   delay(WATERPOSTDELAY);
  }

  float h = dht.readHumidity();
  float f = dht.readTemperature(true);  // Fahrenheit

  if (isnan(h) || isnan(f)) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }
 
    lcd.setCursor(0, 0);
    lcd.print("Temp: ");
    lcd.print(f, 1);  // print only one decimal digit due to limited space
    lcd.print("\337F");

      
    lcd.setCursor(0, 1);
    lcd.print("SoilMoisture:");
    lcd.print(sensorValue);

  
//    lcd.setCursor(0,1);
//    lcd.print("Humidity: "); 
//    lcd.print(h, 1);
//    lcd.print("%");

//    Serial.print("Temp: ");
//    Serial.print(f);
//
//    Serial.print("Humidity: ");
//    Serial.print(h);

    //Serial.print("Soil Moisture: ");
    //Serial.print(sensorValue);
    
  delay(5000);
}