【写在前面】这是我的第一个专栏投稿。这篇专栏代表着一个新坑的开始。我会不定期，但相对频繁的发布新的专栏，推荐我经常用的，和我新发现的Vim/NeoVim插件。我很希望这些专栏被更多Vim用户看到，所以如果想支持我，请把这篇文章，以及未来的专栏转发给你同样用Vim的朋友们！谢谢～

![](https://i0.hdslb.com/bfs/article/0117cbba35e51b0bce5f8c2f6a838e8a087e8ee7.png)

Hey大家好，作为这个Vim插件介绍系列的第一个专栏，我想先把怎么装插件说清楚。没错，你需要一个vim插件来安装vim插件。虽然现在Vim和Neovim都开始自带插件管理功能，但一个插件管理器会让你安装以及升级vim插件的过程变得更加方便快捷。

![](https://i0.hdslb.com/bfs/article/b4cb0b6a330f683413fc1966a0294cd9214f8c56.gif)

使用vim-plug一键安装插件

我推荐的vim插件管理器是vim-plug。

想安装的话，下载

https://raw.githubusercontent.com/junegunn/vim-plug/master/plug.vim

并把它放到

**~/.vim/autoload/** 里（Vim用户）

或 **~/.config/nvim/autoload/** 里（ Neovim用户）

如果你发现这个文件不存在，你可以搜索“解决GitHub的raw.githubusercontent.com无法连接问题“

把plug.vim放到正确的位置之后，你就可以开始安装插件了。在你的vim配置文件中，写下这两行：

Vim用户：

    call plug#begin('~/.vim/plugged')

    call plug#end()

Neovim用户：

    call plug#begin('~/.config/nvim/plugged')

    call plug#end()  
在这两行你可以开始添加你想安装的vim插件了。vim插件通常在github上能找到（特殊情况见本文中**其他情况**部分）。我用我正在使用的vim配色插件举例：

https://github.com/theniceboy/vim-deus

想安装这个插件，去掉"https://github.com/"，在刚才那两行之间插入：Plug 'theniceboy/vim-deus'

![](https://i0.hdslb.com/bfs/article/8c21fde01b33e4c2d8d26df99a685d98ca046060.png@1320w_780h.webp)

接下来，重启你的Vim（或者在Vim中运行 :so % ），接下来，在运行 :PlugInstall 之后你就能看到vim-plug开始安装这个插件了。如果你看到这个错误：

Not an editor command: PlugInstall

那么说明你的vim-plug没有正确安装，请回到**安装vim-plug**。

对于这个你刚刚安装的插件（vim-deus）你可以运行:color deus 来确定你有没有安装成功。

俗话说得好，Don't mess with it if it works. 很多人不习惯升级已经安装的插件，这完全没有问题。但如果你想升级你所有的Vim插件的话，简单，在Vim中运行 :PlugUpdate 就好了。你还可以通过 :PlugUpgrade 来检查vim-plug本身的更新。（vim-plug自身也是一个vim插件。通过 :PlugUpdate 不会检查自身的更新）

如果你有一个自动更新系统所有软件的脚本的话你可以在你的脚本里增加一行：

vim +PlugUpdate +quit +quit

来自动打开vim，升级vim插件，并关闭vim。

升级完vim插件之后，你还可以查看具体哪个插件都有什么新的变化。把光标移动到更新状态都窗口按“D”，vim-plug就会帮你整理出一个插件更新内容列表。

如果你有哪个vim插件不想要了，只要删掉你Vim配置文件中的 Plug 'xxx/xxx' 那一行就好了。下次Vim启动的时候，那个插件就不会被加载。这样做并不会删掉那个插件的文件。你可以通过:PlugClean 来删除所有的已经不用了的插件的文件。

vim-plug提供了很多额外的选项。如果你安装了很多插件，然后发现这些插件让你的Vim的启动速度变慢了的话，你可以选择让一些插件不在Vim启动的时候加载，或者说让一些插件只在编辑某个特定类型的文件的时候在被加载。下面我来举一些例子来让你们更方便的理解这个vim-plug的功能。

Plug 'scrooloose/nerdtree', { 'on':  'NERDTreeToggle' }

只有在执行 :NERDTreeToggle 的时候才加载这个插件

Plug 'fatih/vim-go' , { 'for': 'go' }

只有在打开.go文件的时候才加载这个插件

Plug 'yuezk/vim-js', { 'for': \['php', 'html', 'javascript'\] }

只有在打开php，html和javascript文件的时候才加载这个插件。

你可以让vim-plug在安装/升级完一个插件之后做一些事情，比如运行一个脚本。

Plug 'Yggdroot/LeaderF', { 'do': './install.sh' }

不用担心，大多数插件都不需要这一步。如果需要的话，插件的README里面会很清楚的标明的。所以在安装插件的时候请先阅读你要安装的那个插件的说明文件（Readme）

vim-plug支持很多安装vim插件的方式。你想安装的vim插件不一定要来自github。你只要提供一个有效的链接即可。

有一些插件更新非常频繁，比如vim-go。你可以通过

Plug 'fatih/vim-go' , { 'tag': '\*', 'for': 'go' }

来让vim-plug从git主分支中最近的一次tag来获取插件的源代码。除了“tag”以外，你还有“branch”和“commit”两个选项。它们分别会让vim-plug从一个特定的git分支和一个特定的git提交来获取代码。

在我的neovim配置文件最前面，有这么一段代码：  

if empty(glob('~/.config/nvim/autoload/plug.vim'))

silent !curl -fLo ~/.config/nvim/autoload/plug.vim --create-dirs https://raw.githubusercontent.com/junegunn/vim-plug/master/plug.vim

autocmd VimEnter \* PlugInstall --sync | source $MYVIMRC

endif

这会让vim在每次启动的时候都检测一下vim-plug有没有被安装。如果没有的话，vim会尝试安装vim-plug，并自动运行:PlugInstall 。如果你用的是Vim，请把

~/.config/nvim/autoload/plug.vim

换成

~/.vim/autoload/plug.vim

这篇专栏写得稍微长了一些，这是因为我在将来的vim插件专栏文章里可以给对安装vim插件有疑问的朋友们发一下这篇文章。如果有疑问，欢迎在评论区发表。感谢各位的支持！

很不幸，b站专栏目前不支持代码段，也不支持markdown。虽然我可以把md转成html，把我的cookie拿出来然后跑一个curl，但我还是希望遵守bilibili的专栏规则。希望b站早日支持markdown，好歹支持一个代码块。如果不行的话，至少加一个等宽字体吧 233333