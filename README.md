![image](https://user-images.githubusercontent.com/81268272/215898888-34be5aa1-9036-4e7f-8b0d-ec820e815db0.png)
Microservices :

Catalog Microservice

Kurslarımız ile ilgili bilgilerin tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.

MongoDb (Veritabanı)

One-To-Many/One-To-One ilişki

<h1><b>MongoDb</b></h1>

Basket Microservice

Sepet işlemlerinden sorumlu olacak mikroservisimiz.

RedisDB(Veritabanı)

Discount Microservice

Kullanıcıya tanımlanacak indirim kuponlarından sorumlu olacak mikroservisimiz.

PostgreSQL(Veritabanı)

Order Microservice

Sipariş işlemlerinden sorumlu olacak mikroservisimiz.

Bu mikroservisimizde Domain Driven Design yaklaşımını kullanarak geliştiriyor olacağız.

Bu mikroservisimizde CQRS tasarım kalıbını uygulamak için MediatR kütüphanesini kullanıyor olacağız.

Sql Server(Veritabanı)

Domain Driven Design

CQRS (MediatR Libarary)

FakePayment Microservice

Ödeme işlemlerinden sorumlu olacak mikroservisimiz.

IdentityServer Microservice

Sql Server(Veritabanı)

Kullanıcı dataların tutulmasından,token ve refreshtoken üretilmesinden sorumlu olacak microservisimiz.

PhotoStock Microservice

Kurs fotograflarının tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.

API Gateway

Ocelot Library

Message Broker

Mesaj kuyruk sistemi olarak RabbitMQ kullanıyor olacağız.

RabbitMQ ile haberleşmek için MassTransit kütüphanesini kullanıyor olacağız.

RabbitMQ (MassTransit Library)

Identity Server

Token / RefreshToken üretmek

Access Token ile microservice'lerimizi korumak

OAuth 2.0 / OpenID Connect protokollerine uygun yapı inşa etmek

Asp.Net Core MVC Microservice

Microservice'lerden almış olduğu dataları kullanıcıya gösterecek ve kullanıcı ile etkileşime geçmekten sorumlu olacak UI mikroservisimiz
