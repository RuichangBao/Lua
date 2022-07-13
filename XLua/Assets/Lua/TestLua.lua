local TestLua = {}
local Object = require("Class.Object")
local Component = require("Class.Component")
print("lua测试脚本")

--[[--局部变量(_G中没有引用)
local a = 400
--全局变量(_G中有引用)
-- b = 400--]]

local obj1 = Object:New()
local obj2 = Object:New()
local obj3 = Object:New()
obj1.num = 100
obj3.num = 300
print(obj1.num)
print(obj2.num)
print(obj3.num)

local Component1 = Component:New()
local Component2 = Component:New()
local Component3 = Component:New()

print(Component1.num)
print(Component2.num)
print(Component3.num)
print(Component1:Tostring())
print(Component2:Tostring())
print(Component3:Tostring())
print("结束")

return TestLua
