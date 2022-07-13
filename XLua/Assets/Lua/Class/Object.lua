local Object = {}

Object.num=200
--Object.__index = self
function Object:New(o)
    o = o or {}
    setmetatable(o, self)
    self.__index = self
    return o
end

function Object:Tostring()
    return("Object.Tostring()")
end

return Object
