## 1. 简介

基于 symfony 的 PHPWeb 开发框架

易于理解，功能强大

注意LTS，非LTS	Long Time Support

大部分框架的特点：

1. 单入口，所有请求必须从带入口开始
2. MVC思想，分层思想，主要为了协同开发，实现后期的维护方便
3. ORM操作数据库，Object Relations Model：AR模式

注意：Laravel 框架所有的URL必须在使用前定义

## 2. 安装

- PHP版本 >= 5.6.4
- PHP扩展：OpenSSL
- PHP扩展：PDO
- PHP扩展：Mbstring
- PHP扩展：Tokenizer

php.ini 配置文件中需要开启的拓展：

- extension=php_openssl.dll
- extension=php_pdo_mysql.dll
- extension=php_mbstring.dll
- extension=php_fileinfo.dll （验证码的代码依赖需要该拓展）
- extension=php_curl.dll（主要用于请求的发送）

httpd.conf 配置文件需要开启的模块：

​	略

## 3. composer

意思：音乐指挥官

是php中的依赖管理工具，php项目准备的软件管家

​	略

## 4. 目录结构

root

- app
  - 控制器 可分目录管理
  - 模型 可分目录管理
- bootstrap
  - 框架启动所需要的配置等a
- config
  - app.php 项目主配置文件
  - auth.php 数据验证
  - database.php 数据库配置
  - filesystems.php 上传文件，文件存储等配置
- database
  - migrations 建表文件（迁移文件，创建数据表）
  - seeds 种子文件（存放数据表的数据填充文件目录）
  - factories 工厂类，相当于Java的工厂
- public
  - 项目的路口文件（不放在根目录就是为了做到单一路口）
  - 静态文件 css，js等
  - robots.txt 用于限制蜘蛛（爬虫）
- resources
  - assets 有用的
  - lang 语言包
  - views 视图 可分目录管理
- routes
  - web.php 主要的路由文件
- storage
  - 主要存放文件和日志文件，注意因为要写文件，在linux下得保证目录可写
- vendor
  - 依赖工具，包等

文件

- .env 系统的环境配置文件
- artisan 脚手架文件，使用本文件可以自动生成很多代码

## 5. 虚拟主机

​	略

## 6. 路由

**概念**：将用户的请求按照实现规划的方案提交到指定的控制器或者功能函数

文件路径：routes/web.php

根路由：/

常用函数：

- get($uri, $callback)
- post($uri, $callback)
- match(['get', 'post'], $uri, $callback)
- any($uri, $callback)

路由设置其他细节：

```php
// 必须参数
Route::get('/test1/{id}', function($id) {
    echo $id;
});

// 不是必须的参数
Route::get('/test2/{id?}', function($id = '') {
    echo $id;
});

// 路由取别名
Route::get('/test3', function() {
    echo '别名';
}) -> name('testRoute');
```

路由群组：

```php
Route::group(['prefix' => 'admin'], function() {
   Route::get('', function() {
       
   });
});
```

## 7. 控制器

文件路径：app/http/controls/* 





















3.视图

位置：

4.模型

位置：自定义，但在app下

模型的使用

model::get();

model::table('table')->get();

$model = new model();

$model->get();

AR模式