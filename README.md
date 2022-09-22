# FastBugly

快速接入bugly到unity，支持Unity2021（Unity5以上版本都支持,当前测试工程为2021.3.9f1）

### 使用方式
CheckOut工程，打开SampleScene，双击打开Sample.cs代码，把自己bugly后台的appid填入BuglyAgent.InitWithAppId ("your ios app id");  随后打安卓包测试即可在后台看到异常上报。

### 初衷
鹅厂提供的官方demo工程打包后台也查不到日志，N年不更新，为此本人做了部分修改测试，提供一个快速接入工程的demo。

Unity2021因为版本原因腾讯官方工程不能使用，而且Unity2021不允许Plugins/Android出现res目录，需要打包成aar，所以改用了原生安卓sdk的aar包。

### 待做
打包放到UPM，方便快速接入
