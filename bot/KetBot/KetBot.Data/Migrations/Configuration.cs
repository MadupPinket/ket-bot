namespace KetBot.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KetBot.Data.Models.KetBotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(KetBot.Data.Models.KetBotContext context)
        {
            // -----------------------------------------------------------
            context.SelectiveForms.AddOrUpdate(p => p.Code,
                new SelectiveForm
                {
                    Code = "0",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 통합",
                        "포인트 사용",
                        "광고 포인트 적립",
                        "멤버십",
                        "상점",
                        "버그신고",
                        "기타"
                    })
                },
                new SelectiveForm
                {
                    Code = "1",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 통합 오류",
                        "포인트 통합 취소",
                        "포인트 통합 기타",
                        "포인트 소멸"
                    })
                },
                new SelectiveForm
                {
                    Code = "2",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 사용"
                    })
                },
                new SelectiveForm
                {
                    Code = "3",
                    Form = string.Join("\n", new string[]
                    {
                        "바로적립",
                        "잠금화면 포인트"
                    })
                },
                new SelectiveForm
                {
                    Code = "4",
                    Form = string.Join("\n", new string[]
                    {
                        "등록 관련"
                    })
                },
                new SelectiveForm
                {
                    Code = "5",
                    Form = string.Join("\n", new string[]
                    {
                        "이용 관련",
                        "상품권"
                    })
                },
                new SelectiveForm
                {
                    Code = "6",
                    Form = string.Join("\n", new string[]
                    {
                        "화면 멈춤"
                    })
                },
                new SelectiveForm
                {
                    Code = "7",
                    Form = string.Join("\n", new string[]
                    {
                        "건의사항",
                        "계정 관련",
                        "클라이언트 관련",
                        "이용 관련",
                        "기타"
                    })
                },
                new SelectiveForm
                {
                    Code = "8",
                    Form = string.Join("\n", new string[]
                    {
                        "화면 멈춤"
                    })
                },
                new SelectiveForm
                {
                    Code = "11",
                    Form = string.Join("\n", new string[]
                    {
                        "전환버튼 클릭 후 반응이 없어요.",
                        "본인인증 과정에서 오류가 있어요.",
                        "보안문자 입력 과정에서 오류가 있어요.",
                        "포인트 통합을 했는데 그대로에요."
                    })
                },
                new SelectiveForm
                {
                    Code = "12",
                    Form = string.Join("\n", new string[]
                    {
                        "실수로 포인트 통합을 해버렸어요.",
                        "포인트 통합을 취소해주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "13",
                    Form = string.Join("\n", new string[]
                    {
                        "다른 카드사 포인트를 통합하고 싶어요.",
                        "통합한 포인트를 다른 카드사로 옮겨 주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "14",
                    Form = string.Join("\n", new string[]
                    {
                        "탈퇴했더니 포인트가 사라졌어요.",
                        "포인트가 사라졌어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "21",
                    Form = string.Join("\n", new string[]
                    {
                        "포인트 사용법을 알고싶어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "31",
                    Form = string.Join("\n", new string[]
                    {
                        "적립이 안됐어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "32",
                    Form = string.Join("\n", new string[]
                    {
                        "적립 포인트 양이 너무 적어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "41",
                    Form = string.Join("\n", new string[]
                    {
                        "멤버십 카드를 자동으로 등록하고 싶어요.",
                        "신용카드를 등록하고 싶어요.",
                        "바코드가 없는데 등록 방법을 알고 싶어요.",
                        "멤버십 포인트를 조회하고 싶어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "51",
                    Form = string.Join("\n", new string[]
                    {
                        "상품 사용 방법을 알고싶어요.",
                        "사용 내역을 확인하고 싶어요.",
                        "다른 상품으로 교환하고 싶어요.",
                        "핀켓 상점 외의 곳에서 사용하고 싶어요.",
                        "해피머니 상품권 사용법을 알려주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "52",
                    Form = string.Join("\n", new string[]
                    {
                        "상품권 사용 방법을 알고싶어요.",
                        "상품권 수령은 어떻게 하나요?",
                        "상품권 기한이 지나버렸어요.",
                        "모바일 상품권 사용 잔액을 알려주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "61",
                    Form = string.Join("\n", new string[]
                    {
                        "화면이 멈췄어요.",
                        "잠금화면 해제 후 포인트가 들어오지 않아요."
                    })
                },
                new SelectiveForm
                {
                    Code = "71",
                    Form = string.Join("\n", new string[]
                    {
                        "건의사항이 있는데요."
                    })
                },
                new SelectiveForm
                {
                    Code = "72",
                    Form = string.Join("\n", new string[]
                    {
                        "탈퇴하는 방법을 알고싶어요.",
                        "번호/기기를 변경하고 핀켓을 쓰고싶어요."
                    })
                },
                new SelectiveForm
                {
                    Code = "73",
                    Form = string.Join("\n", new string[]
                    {
                        "재설치 시 기존 적립 포인트를 사용 할 수 있나요?"
                    })
                },
                new SelectiveForm
                {
                    Code = "74",
                    Form = string.Join("\n", new string[]
                    {
                        "로그인 하고싶어요.",
                        "로그아웃 하고싶어요.",
                        "아이디(비밀번호)를 알려주세요.",
                        "아이디 변경을 하고싶어요.",
                        "비밀번호를 변경하고싶어요.",
                        "이름을 바꾸고 싶어요.",
                        "잠금화면을 해제하고싶어요.",
                        "잠금화면 포인트 적립 주기를 알고싶어요.",
                        "사용법을 가르쳐주세요."
                    })
                },
                new SelectiveForm
                {
                    Code = "75",
                    Form = string.Join("\n", new string[]
                    {
                        "고객센터를 알려주세요."
                    })
                }
            );

            // -----------------------------------------------------------

            context.ExecutiveQuestions.AddOrUpdate(p => p.Code,
                new ExecutiveQuestion
                {
                    Code = "111",
                    Keyword = "포인트 전환",
                    Question = "전환버튼 클릭 후 반응이 없어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "질문하신 내용은 최신 앱 버전에서 패치가 적용되었습니다. 다음 방법대로 시도해보세요. :)"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. 기존에 설치된 앱 삭제\n 2. 구글 플레이 스토어에서 최신 버전으로 재설치"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "이후에도 동일한 문제가 발생한다면, 매니저에게 물어봐주세요!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "112",
                    Keyword = "본인인증",
                    Question = "본인인증 과정에서 오류가 있어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "질문하신 내용은 최신 앱 버전에서 패치가 적용되었습니다. 다음 방법대로 시도해보세요. :)"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. 기존에 설치된 앱 삭제 2. 구글 플레이 스토어에서 최신 버전으로 재설치"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "이후에도 동일한 문제가 발생한다면, 매니저에게 물어봐주세요!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "113",
                    Keyword = "보안문자",
                    Question = "보안문자 입력 과정에서 오류가 있어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "질문하신 내용은 최신 앱 버전에서 패치가 적용되었습니다. 다음 방법대로 시도해보세요. :)"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. 기존에 설치된 앱 삭제 2. 구글 플레이 스토어에서 최신 버전으로 재설치"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "이후에도 동일한 문제가 발생한다면, 매니저에게 물어봐주세요!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "114",
                    Keyword = "연체/해지 관련",
                    Question = "포인트 통합을 했는데 그대로에요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "말씀하신 내용은 보통 몇 가지 이유가 있어요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. 통합하시려는 금융사에 연체기록이 있거나 해지하신 경우 2. 통합하시려는 액수가 금융사에서 정한 액수보다 작거나 큰 경우"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "1번의 경우, 해당 카드사로 직접 문의해 보세요. 2번의 경우에는 금융사마다 다르지만 보통 한 번에 100원 혹은 500원 이상, 50만원 이하만 통합 가능하답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "121",
                    Keyword = "오통합",
                    Question = "실수로 포인트 통합을 해버렸어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "이런!! 많이 놀라셨겠네요. 하지만 걱정 마세요!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "입력창을 통해서 매니저님에게 물어보면 해결해 주실 수 있어요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "보통 전산처리 기간에 따라 2~3영업일이 걸린다고 하네요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "122",
                    Keyword = "단순취소",
                    Question = "포인트 통합을 취소해주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = " 포인트 통합 취소는, 입력창을 통해서 매니저님에게 직접 요청하셔야 한답니다.]"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "제 권한 밖이지만 매니저님께 상황을 말씀드리면 해결해주실꺼에요!"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "보통 전산처리 기간에 따라 2~3영업일이 걸린다고 하네요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "131",
                    Keyword = "제휴처 외 카드사",
                    Question = "다른 카드사 포인트를 통합하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "아쉽게도, 제휴리스트에 없는 카드사는 아직 통합하실 수 없어요. ㅠㅡ"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "점점 더 많은 곳과 제휴중이니, 곧 가능할꺼에요!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "132",
                    Keyword = "역통합",
                    Question = "통합한 포인트를 다른 카드사로 옮겨 주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "카드사마다 약관이 다르기 때문에, 통합한 포인트를 다른 카드사로 옮길 수는 없어요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "141",
                    Keyword = "탈퇴회원",
                    Question = "탈퇴했더니 포인트가 사라졌어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "탈퇴하신 경우 저희도 개인정보를 전부 삭제하기 때문에 아쉽게도 제가 해결해 드릴 수가 없어요. ㅠㅡ"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "탈퇴를 하실 경우 팝업창에서 먼저 주의를 드리니, 꼭 확인해주세요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "142",
                    Keyword = "기타 소멸",
                    Question = "포인트가 사라졌어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "포인트가 사라지다니!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "빨리 매니저님에게 말씀해주세요. 해결책을 찾아주실 꺼에요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "211",
                    Keyword = "사용법",
                    Question = "포인트 사용법을 알고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "열심히 포인트를 모으셨군요!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "핀켓 포인트는 '포인트 관리' 화면 하단의 '상점'에서 사용하실 수 있어요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "점점 더 많은 사용처가 생길 거라고 하니까, 기대해주세요! >ㅁ<"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "311",
                    Keyword = "포인트 미적립",
                    Question = "적립이 안됐어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "이럴수가.. 얼른 해결해 드릴께요!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "바로적립 광고 참여의 경우에는, 바로적립 화면 왼쪽 위를 누르셔서 해당 광고사에 문의를 하시면 상세하게 답변을 받으실 수 있구요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "그 외의 이유로 적립이 되지 않았다면, 매니저님에게 물어봐주세요. "
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "321",
                    Keyword = "적립 일반",
                    Question = "적립 포인트 양이 너무 적어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "포인트를 더 모을 수 있는 방법이 있어요!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "바로적립 참여를 통해 100포인트부터 무려 2000포인트 가까이 한 번에 모으실 수 있답니다. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "지금 시도해보세요!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "411",
                    Keyword = "자동 등록",
                    Question = "멤버십 카드를 자동으로 등록하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "멤버십 카드는 카드의 번호와 바코드를 이용해서 직접 등록해서 사용해야 해요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "가족이나 친구의 멤버십카드를 함께 등록해서 사용하실 수도 있답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "412",
                    Keyword = "기타 등록",
                    Question = "신용카드를 등록하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "아쉽게도, 신용카드 등록 및 사용은 아직 지원하지 않고 있어요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "곧 더 다양한 기능이 추가 될 예정이니, 기대해주세요!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "413",
                    Keyword = "기타 등록",
                    Question = "바코드가 없는데 등록 방법을 알고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "멤버십 등록은 이렇게!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = @"https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fmadupfinket%2Fposts%2F1658200141137008&width=500"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "해당 페이스북 링크를 타고 가시면, 멤버십의 모든 것을 알 수 있어요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "414",
                    Keyword = "포인트 조회",
                    Question = "멤버십 포인트를 조회하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "에고.. 아직 멤버십 포인트 자동 조회 기능은 지원하지 않고 있답니다."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "점점 더 다양한 포인트 조회, 통합 및 사용 기능이 추가되고 있으니 앞으로도 잘 부탁드려요!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "511",
                    Keyword = "사용법",
                    Question = "상품 사용 방법을 알고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "열심히 모은 그대, 잘 써라!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "구매하신 상품은 해당 매장에서 보관함의 쿠폰을 보여주는 것으로 사용하실 수 있어요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "해피포인트나 문화상품권은 충전해서 쓰실 수도 있답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "512",
                    Keyword = "사용 내역",
                    Question = "사용 내역을 확인하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "사용 내역이 궁금하신가요?"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "핀켓어플리케이션 > 포인트 관리 > 상점 > 상점 하단의 구매 상품 보관함에서 구매 및 사용 내역을 확인하실 수 있어요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "또한, 상품권의 경우 해당 매장이나 매장 사이트에서 확인도 가능하답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "513",
                    Keyword = "상품 교환",
                    Question = "다른 상품으로 교환하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "상품 교환은, 이미 구매하신 상품을 취소하신 후 재구매 하시면 됩니다."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "우선, 매니저님에게 상품 취소를 문의해주세요. :)"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "514",
                    Keyword = "사용처",
                    Question = "핀켓 상점 외의 곳에서 사용하고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "이런.. 핀켓상점으로는 부족하신거군요!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "현재 더 다양한 상품 및 소비처를 만들기 위해 노력하고 있으니 조금만 더 기다려주세요!"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "이외에도 상품권 구매를 통해서 사용하시는 방법도 있답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "515",
                    Keyword = "사용법",
                    Question = "해피머니 상품권 사용법을 알려주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "해피머니 사용법이 궁금하신거군요!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "우선, 해피머니상품권 홈페이지 방문 > 로그인 > 홈페이지 상단의 '상품권' > '상품권 교환소' 클릭 > '아이넘버'를 선택해주세요. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "그리고 교환권번호(위 번호 12자리)입력 > 확인버튼을 누르시면 휴대폰으로 16자리 핀번호돠 발행일을 확인하실 수 있답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "521",
                    Keyword = "사용법",
                    Question = "상품권 사용 방법을 알고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "상품권 사용 말씀이시군요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "상품권은 해당 매장에서 핀켓 어플리케이션 내 '보관함'의 해당 상품권 바코드를 보여주시면 교환 혹은 사용이 가능해요. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "또, 문화상품권과 해피머니는 온라인에서 쿠폰번호를 이용해 충전이 가능하답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "522",
                    Keyword = "사용법",
                    Question = "상품권 수령은 어떻게 하나요?",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "상품권 수령은 말이죠. 일단 사용 가능한 매장을 방문해 주세요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "그리고, 해당 매장에서 핀켓 어플리케이션 내 '보관함'의 해당 상품권 바코드를 보여주시면 교환 혹은 사용이 가능해요. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "문화상품권과 해피머니는 별도의 수령 없이 온라인으로 충전하실 수도 있지요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "523",
                    Keyword = "기한연장",
                    Question = "상품권 기한이 지나버렸어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "저런 저런, 기한이 지나버렸군요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "상품권은 '1회에 한해 30일 연장'이 가능하답니다. 잊지 말고 꼭 기한 안에 사용해주세요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "참, 제휴사측에 연장처리를 요청하기 위해 매니저님께 유효기간이 지난 상품권 번호를 잊지 말고 보내주세요. :)"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "524",
                    Keyword = "잔액 확인",
                    Question = "모바일 상품권 사용 잔액을 알려주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "상품권 잔액이 궁금하신가요??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "잔액 확인은 상품권 사용이 가능한 어느 매장에서든 상품권 번호를 말씀하시면 확인이 가능하답니다. :)"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "611",
                    Keyword = "화면 멈춤",
                    Question = "화면이 멈췄어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "화면이 멈추신 경우에는 회원님께서 사용하고 계시는 휴대전화 기종과 문제가 되는 화면을 캡쳐해서 service@finket.co.kr로 보내주세요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "개발팀과 함께 원인을 찾아서 꼭! 해결해드리겠습니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "612",
                    Keyword = "포인트 관련",
                    Question = "잠금화면 해제 후 포인트가 들어오지 않아요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "잠금해제 포인트의 경우 통신상태가 안좋은 간혹 적립 오류가 발생합니다."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "통신상태를 체크해주시고, 같은 문제가 지속적으로 발생하는 경우, 매니저님께 사용하시는 휴대폰 기종과 앱의 버전을 보내주시면 빠른 시일 내에 처리해드릴께요!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "711",
                    Keyword = "건의사항",
                    Question = "건의사항이 있는데요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "Wow!! 회원님의 반짝이는 아이디어는 언제나 환영입니다!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "매니저님께 아이디어를 보내주시면 조금 더 좋은 서비스가 될 수 있을꺼에요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "721",
                    Keyword = "탈퇴",
                    Question = "탈퇴하는 방법을 알고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "이런.. 회원님 꼭 떠나셔야 하시나요 ;ㅁ;"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "탈퇴는 설정의 내 정보 변경을 통해 진행하실 수 있으며, 탈퇴 시 남은 포인트는 소멸되오니, 이 점 꼭 기억해주세요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "더 좋은 모습으로 뵐 수 있게, 열심히 하고있겠습니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "722",
                    Keyword = "번호/기기 변경",
                    Question = "번호/기기를 변경하고 핀켓을 쓰고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "와우. 번호나 기기를 변경하셨나요??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "교체하신 휴대폰에 핀켓을 설치하신 후 기존에 사용하시던 아이디로 로그인 하시면 그대로 사용하실 수 있어요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "참, 아쉽게도 아직 아이폰은 지원하지 않는답니다. ㅠㅠ 곧 아이폰으로도 찾아뵐께요!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "731",
                    Keyword = "재설치",
                    Question = "재설치 시 기존 적립 포인트를 사용 할 수 있나요?",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "재설치를 하셨군요. 당연히 그대로 사용 가능하세요!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "재설치 후 기존에 등록하셨던 아이디로 로그인 하시면 된답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "741",
                    Keyword = "로그인",
                    Question = "로그인 하고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "로그인이 안되시나요??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "잠시 서버에 문제가 있거나, 회원님 기기의 통신상태가 안좋을 수 있습니다. 잠시 후 다시 시행해주세요."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "그래도 여전히 로그인이 되지 않는다면, 매니저님께 기종과 버전을 함께 문의 주시면 해결해 드릴꺼에요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "742",
                    Keyword = "로그아웃",
                    Question = "로그아웃 하고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "로그아웃을 원하시나요?"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "로그아웃 방법은 '핀켓 앱 실행' > '사용자설정' > '나의 정보' 에 들어가셔서 로그아웃 버튼을 누르시면 된답니다."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "743",
                    Keyword = "아이디/비밀번호 분실",
                    Question = "아이디(비밀번호)를 알려주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "저런. 아이디나 비밀번호를 잊어버리셨군요. 괜찮아요. 저도 로봇이지만 자주 그런답니다."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "아이디는 '사용자 설정>나의정보'에 들어가셔서 확인이 가능하구요. 비밀번호는 암호화 되어있어서 변경을 해주셔야 한답니다."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "로그인 화면 하단의 '로그인 정보를 잊으셨나요?를 통해 이메일을 인증하시고 새 비밀번호를 입력하시면 돼요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "744",
                    Keyword = "아이디 변경",
                    Question = "아이디 변경을 하고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "아이디를 변경하고 싶으시군요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "아쉽게도 아이디는 본인인증 및 휴대폰과 연동되어 변경이 불가능합니다."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "금융 서비스의 특성상 변경 절차가 까다로운 점 양해 부탁드려요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "745",
                    Keyword = "비밀번호 변경",
                    Question = "비밀번호를 변경하고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "비밀번호 변경방법요?"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "로그인 화면 하단의 '로그인 정보를 잊으셨나요?'를 누르신 후 이메일 인증을 통해 변경하실 수 있어요."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "746",
                    Keyword = "이름 변경",
                    Question = "이름을 바꾸고 싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "이름을 바꾸고 싶으시군요! 저도 제 이름 '켓'을 가끔 '캣'으로 쓰다가 고친답니다."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "변경하시고 싶은 이름을 매니저님께 보내주세요. 그럼 바로 처리해드릴꺼에요!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "747",
                    Keyword = "잠금화면",
                    Question = "잠금화면을 해제하고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "잠금화면이 불편하셨나요??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "잠금화면 해제는 핀켓 어플리케이션을 실행 하신 후 '사용자 설정' > '잠금화면 설정' 에서 하실 수 있답니다."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "잠금화면을 통해서 컨텐츠도 읽고 추가 포인트도 적립받을 수 있으니 한 번 더 생각해주세요! :)"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "748",
                    Keyword = "잠금화면",
                    Question = "잠금화면 포인트 적립 주기를 알고싶어요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "앗! 포인트 적립 주기는 제 비밀인데요!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "몰래 말씀드리는건데, 삼십분에 2~3포인트 정도 쌓인답니다. 각종 광고를 보시면 훨씬! 많이 쌓이겠죠?"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "749",
                    Keyword = "사용법",
                    Question = "사용법을 가르쳐주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "오! 사용법이요? 사용법은 물론 재미난 이야기는 덤!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fmadupfinket%2Fposts%2F1645271335763222&width=500"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "위의 링크를 누르시면 페이스북의 핀켓 페이지에서 유용한 정보와 사용법을 한 번에 보실 수 있어요. :)"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "751",
                    Keyword = "고객센터",
                    Question = "고객센터를 알려주세요.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "고객센터는 총 세 가지 방법으로 이용하실 수 있어요."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. 저에게 물어보시면 되구요! 2. 매니저님에게 물어보시면 제가 못도와드린 내용 도와드릴꺼에요. 그리고 3. 카카오 플러스 친구에서 'finket'을 검색하시면, 매니저님과 대화가 가능하답니다. ]"
                        }
                    }
                }

            );

            //// -----------------------------------------------------------
            context.CommentDefinitions.AddOrUpdate(p => p.Code,
                new CommentDefinition
                {
                    Catetory = "Greetings",
                    Code = "RGB01",
                    Definition = "기본 인삿말",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "안녕하세요! :)"
                        },
                        new Comment
                        {
                            Text = "오! 부르셨나요, 회원님?"
                        },
                        new Comment
                        {
                            Text = "저를 찾으셨다고 들었어요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Introduce",
                    Code = "RIB01",
                    Definition = "봇 소개",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "회원님을 도와드리러 온 '켓'이라고 해요!"
                        },
                        new Comment
                        {
                            Text = "저는 켓이에요. 회원님의 친구죠."
                        },
                        new Comment
                        {
                            Text = "회원님이 절 부른 이유.. 맞춰볼께요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "PreProposal",
                    Code = "RPB01",
                    Definition = "제안 전 멘트",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "제가 도와드릴 수 있는 내용을 보여드릴께요."
                        },
                        new Comment
                        {
                            Text = "요즘 이런 내용으로 저를 많이 찾으시더라구요."
                        },
                        new Comment
                        {
                            Text = "이 중에 절 찾은 이유가 있으면 좋겠네요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "RCB01",
                    Definition = "확인 멘트",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "고르신 내용이 {0} 맞나요?"
                        },
                        new Comment
                        {
                            Text = "선택하신 항목이 {0}이죠?"
                        },
                        new Comment
                        {
                            Text = "{0}에 대해 질문하셨군요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "SCU01",
                    Definition = "확인 멘트",
                    Owner = "User",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "네, 맞아요!"
                        },
                        new Comment
                        {
                            Text = "아닌데요?"
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Request",
                    Code = "SRU01",
                    Definition = "기타 요청",
                    Owner = "User",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "아까 했던 말 다시 해주세요!"
                        },
                        new Comment
                        {
                            Text = "매니저님한테 물어볼래요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Proposal",
                    Code = "RPB02",
                    Definition = "중간 제안시",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "조금 더 자세히 말씀해주세요."
                        },
                        new Comment
                        {
                            Text = "그렇다면 이런 내용이겠군요."
                        },
                        new Comment
                        {
                            Text = "말씀하신 내용은 이런 것들과 관계가 있어요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Proposal",
                    Code = "RPB03",
                    Definition = "최종 제안시",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "혹시 궁금하신 내용이 이거 아닌가요?"
                        },
                        new Comment
                        {
                            Text = "저한테 물어보고 싶은 내용이 이건가요?"
                        },
                        new Comment
                        {
                            Text = "질문은 이 안에 있다!"
                        },
                        new Comment
                        {
                            Text = "아마도 이런 내용이 궁금하신 것 같은데요!"
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Proposal",
                    Code = "RPB04",
                    Definition = "응답시",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "아하.. 띠리리리리리... 네 답변 찾았어요."
                        },
                        new Comment
                        {
                            Text = "음 어려운 질문이지만, 알고 있는 내용이에요!"
                        },
                        new Comment
                        {
                            Text = "이런 예리한 질문을?! 그렇다면.."
                        },
                        new Comment
                        {
                            Text = "걱정 마세요. 답변해드릴께요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "RCB02",
                    Definition = "응답후",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "제가 충분히 답변해 드렸나요??"
                        },
                        new Comment
                        {
                            Text = "궁금한 건 다 해결되셨죠?"
                        },
                        new Comment
                        {
                            Text = "제가 좀 똑똑한가봐요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "RCB03",
                    Definition = "문제해결시",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "역시. 제가 요즘 대세 인공지능이에요."
                        },
                        new Comment
                        {
                            Text = "다행이네요. 더 남기실 이야기 있으신 경우 언제든!! 저 말고 매니저님에게 말씀해주세요! :)"
                        },
                        new Comment
                        {
                            Text = "와우 오늘도 좋은 일 한 것 같아서 좋아요!"
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Exception",
                    Code = "REB01",
                    Definition = "사용자 입력 오류",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "제가 아는 내용이 아니에요. 위에서 골라주세요."
                        },
                        new Comment
                        {
                            Text = "제가 말씀드린 내용 안에서 골라주세요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Exception",
                    Code = "REB02",
                    Definition = "예외사항 대응",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "제가 아직 한국어 듣기가 서툴러요. 숫자로 말해주세요."
                        },
                        new Comment
                        {
                            Text = "알아듣지 못했어요. 숫자로 말해주세요."
                        },
                        new Comment
                        {
                            Text = "잘못 입력하셨어요! 숫자로 말해주세요."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Bye",
                    Code = "RBB01",
                    Definition = "최종 멘트",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "그럼, 다음에 또 봐요~~"
                        },
                        new Comment
                        {
                            Text = "필요하실 땐 언제든 불러주세요!"
                        },
                        new Comment
                        {
                            Text = "다행이네요! 또 뵐께요. 이만총총~"
                        }
                    }
                }
            );
        }
    }
}
