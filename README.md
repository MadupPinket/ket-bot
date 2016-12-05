English version is here.

핀켓 CS ChatBot
==================

[매드업](http://madup.com)과 마이크로소프트가 함께 HackFest를 통해서 [핀켓 앱](http://finket.co.kr/)의 CS(Customer Satisfaction) 기능을 강화하기 위해 ChatBot을 만들었습니다. 자세한 소개는 "[핀켓 CS Chatbot 만들기](https://blogs.msdn.microsoft.com/eva/?p=12706)"를 참조 바랍니다. 

<p><a href="https://youtu.be/iUrwiaHB7p4" target="_blank"><img src="https://raw.githubusercontent.com/MadupPinket/ket-bot/master/docs/images/FINKET%20DEmo.jpg" alt="FINKET Demo" style="max-width:100%;"></a></p>

[Microsoft Bot Framework](https://dev.botframework.com/)는 Bot을 만들기 위해 마이크로소프트가 운영하는 서비스와 SDK입니다. Bot Connector라는 서비스를 중심으로 Skype, Facebook Messenger등의 채널을 우리가 만들 Bot에 연결시켜 줍니다. Node.js 와 C# 을 지원하는 Bot Builder SDK를 사용하면 빠르게 Bot을 만들 수 있습니다. 본 과제에서는 C#을 사용했습니다. 

## 개발 환경

### Bot
- Windows 10 / Visual Studio 2015
- C# 
- Entity Framework
- [Bot Framework Template](http://aka.ms/bf-bc-vstemplate) 
- [Bot Framework Emulator](https://aka.ms/bf-bc-emulator)

### App
- Windows 10 / Eclipse 
- Java 
- Android SDK

## 유용한 문서

- [Getting started in .NET](https://docs.botframework.com/en-us/csharp/builder/sdkreference/gettingstarted.html)
- [Microsoft Bot Framework 문서](https://docs.botframework.com/en-us/)
- [Direct Line REST API 1.1](https://docs.botframework.com/en-us/restapi/directline/#navtitle)


## 아키텍쳐 다이어 그램 

 ![FINKET CS Bot Diagram](/docs/images/madup bot diagram.jpg)

- 사용자는 Android앱을 통해서 메시지를 입력하여 Bot에 전달하거나 Bot이 전달 해준 메시지를 받습니다. 
- 사용자가 입력한 메시지는 Direct Line REST API를 통해서 Bot Connector에 전달 되고 Bot Connector는 올바른 Bot에게 메시지를 전달 합니다. 
- Bot은 적절한 질문과 대답을 데이터베이스에서 조회해서 사용자에게 전달합니다. 
- Bot은 Azure Web App 에 배포해서 운영하고 데이터 베이스는 Azure SQL Database를 사용합니다. 

## 배포환경 

 1. Azure Web App : Bot 배포 
 1. Azure SQL Database : 질문 답변이 담겨있는 데이터베이스 
 1. Android App: 에뮬레이터 또는 실제 디바이스

## Configuration 

web.config (Web.Debug.config, Web.Release.config)에 설정해줘야 하는 값들 

1. Database ConnectionString: Azure SQL Database의 연결 문자열을 설정해줍니다.
1. Microsoft App Id: http://dev.botframework.com 에서 Bot을 등록하면서 얻을 수 있습니다. 
1. Microsoft App Password: 역시 Bot을 등록하면서 얻을 수 있습니다.

## 데이터베이스 마이그레이션 (Entity Framework)

Visual Studio의 Package Manager 창을 띄워서 아래 명령을 실행하면 web.config에 설정되어 있는 데이터베이스 ConnectionString에 설정된 데이터베이스에 테이블과 관계가 만들어지고 Seed 데이터가 입력됩니다. 

    > Update-Database -ProjectName KetBot.Data

## 코드 흐름 

 ![FINKET CS Bot Code Flow](/docs/images/madup bot code flow.jpg)

IDialog를 상속받은 xxxDialog들이 Chain으로 연결되어 작동된다. Dialog들의 연결은 /bot/KetBot/KetBot/Dialogs/KetBotChainDialog.cs 에 코딩되어 있습니다. 

## Microsoft Bot Framework 기초 강좌 

[Microsoft Bot Framework 시작해보기 (1)](http://youngwook.com/220833049518)
[Microsoft Bot Framework 시작해보기 (2) Hello Bot Framework](http://youngwook.com/220833329084)
[Microsoft Bot Framework 시작해보기 (3) Bot Application 배포](http://youngwook.com/220833898434)
[Microsoft Bot Framework 시작해보기 (4) Bot 등록과 스카이프에서 테스트 하기](http://youngwook.com/220838138807)
[[Microsoft Bot Framework] Direct Line REST API 3.0](https://blogs.msdn.microsoft.com/eva/?p=12625)
[[Microsoft Bot Framework] Dialog를 사용하여 대화의 흐름 만들기](https://blogs.msdn.microsoft.com/eva/?p=12705)
[[Microsoft Bot Framework] 상태저장을 위한 Bot State Service](https://blogs.msdn.microsoft.com/eva/?p=12715)

*Enjoy with your bot!!*

