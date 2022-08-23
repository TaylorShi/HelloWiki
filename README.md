## 背景

使用WinForms或者WPF里面自带的WebBrowser控件来加载网页时，该控件会默认使用IE7的标准模式加载网页，但是有些网页可能要求在特定的模式下运行才有较好的兼容性，但是微软提供了一个注册表方法，只需要将程序名称添加到对应注册表位置，那么它将不以兼容视图模式运行以便提高对访问网站的兼容性。

> Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. Default value for applications hosting the WebBrowser Control

Windows Internet Explorer 8及以后的版本`FEATURE_BROWSER_EMULATION`特性定义了Internet Explorer的默认仿真模式，支持以下数值:

| 数值 | 描述 |
|:---|:---|
| `11001 (0x2AF9)` | Internet Explorer 11, 网页在IE 11的Edge模式下显示，不管是否声明了`!DOCTYPE`指令。如果没有声明`!DOCTYPE`指令，会导致网页在`Quirks`中加载。|
| `11000 (0x2AF8)` | Internet Explorer 11, 包含基于标准的`!DOCTYPE`指令的网页在IE 11 Edge模式下显示。**Internet Explorer 11的默认值**。|
| `10001 (0x2711)` | Internet Explorer 10, 网页在IE 10的标准模式下显示，与`!DOCTYPE`指令无关。|
| `10000 (0x02710)` | Internet Explorer 10, 包含基于标准的`!DOCTYPE`指令的网页在IE 10标准模式下显示。**Internet Explorer 10的默认值**。|
| `9999 (0x270F)` | Internet Explorer 9, 网页在IE 9标准模式下显示，不管是否声明了`!DOCTYPE`指令。如果没有声明`!DOCTYPE`指令，就会导致页面以`Quirks`模式加载。|
| `9000 (0x2328)` | Internet Explorer 9, 包含基于标准的`!DOCTYPE`指令的网页在IE 9模式下显示。**Internet Explorer 9的默认值**。<br>在Internet Explorer 10中，包含基于标准的`!DOCTYPE`指令的网页会在IE 10标准模式下显示。|
| `8888 (0x22B8)` | Internet Explorer 8, 网页在IE 8标准模式下显示，不管是否声明了`!DOCTYPE`指令。如果没有声明`!DOCTYPE`指令，就会导致页面以Quirks模式加载。|
| `8000 (0x1F40)` | Internet Explorer 8, 包含基于标准的`!DOCTYPE`指令的网页在IE 8模式下显示。**Internet Explorer 8的默认值**。<br>在Internet Explorer 10中，包含基于标准的`!DOCTYPE`指令的网页会在IE10标准模式下显示。|

## 相关文章

* [温故知新，遇见WPF/WinForms，托管控件WebBrowser按本机浏览器版本修正仿真配置，提高运行兼容性](https://www.cnblogs.com/taylorshi/p/16617744.html)