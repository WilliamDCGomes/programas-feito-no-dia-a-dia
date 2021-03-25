import 'dart:html';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:permission_handler/permission_handler.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    final statuses = [
      Permission.storage,
    ].request();
    SystemChrome.setEnabledSystemUIOverlays([]);
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: MyHomePage(title: 'Flutter Demo Home Page'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  MyHomePage({Key key, this.title}) : super(key: key);

  final String title;

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {

  @override
  void dispose() {
      _controller.dispose();
      super.dispose();
  }

  final PageController _controller = PageController(
    initialPage: 0,
  );


  Widget build(BuildContext context) {
    final pages = PageView(
      controller: _controller,
      children: [
        HomeWidget(),
        PhotoWidget(),
      ],
    );
    return pages;
  }
}

class HomeWidget extends StatelessWidget{
  Widget build(BuildContext context){
    final children = new Scaffold(
      body: new Image.asset(
        "images/home1.png",
        fit: BoxFit.cover,
        height: double.infinity,
        width: double.infinity,
      ),
    );
    return new GestureDetector(
      onTapDown: (TapDownDetails details) => _onTapDown(details),
      child: children,
    )
  }
}
