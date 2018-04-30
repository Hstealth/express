fs
//删除文件 unlink方法
fs.unlink('./helloworld.js',err=>{
  if(err) throw err
  console.log('删除成功')
})
fs.unlinkSync('/tmp/hello');
//重命名方法
fs.rename('./text.txt','./main.txt',err=>{
  if(err) throw err
  console.log('重命令完成')
})
//获取文件属性信息
fs.stat('./text.txt',(err,stats)=>{
	if(err) throw err
	console.log(`属性${JSON.stringify(stats)}`)
})

//读文件的操作
fs.readFile('./main.txt',(err,content)=>{
  if(err) throw err 
  console.log(content)
})